#pragma once
#include "stdafx.h"
#include "Windows.h"
#include "Winnt.h"
#include <string>
#include "winuser.h"
#include "call_SV.h"
using namespace std;
using namespace System;
	//call_sv初步debug通过


	class _declspec(dllexport) _DSTServer
	{
	public:typedef struct sv_args
	{
		LPWSTR a1 = nullptr;
		LPWSTR a2 = nullptr;
		LPWSTR a3 = nullptr;
		LPWSTR a4 = nullptr;
		LPWSTR a5 = nullptr;
		LPWSTR a6 = nullptr;
		LPWSTR a7 = nullptr;
		bool a8 = 1;
		char a9 = 4;
		char a10 = 15;
		WCHAR* a11 = nullptr;
	};
		   sv_args arg;



	protected:PROCESS_INFORMATION pi_SV = { 0 };
			  STARTUPINFOW si_SV = { 0 };
	public:bool call_sv
		   (
			   wstring rs,// /Klei
			   wstring conf_dir,// /DontStraveToghter
			   wstring CLUSTER,// 类同/Cluster1
			   wstring SHARD,//字符串，如Master,Caves
			   wstring token,//非本地模式指定token	
			   wstring LOGBACKUP,//日志备份目录
			   wstring EXECFILE,//服务器可执行文件目录
			   bool offline,//false广播到steam网络，true仅局域网
			   char maxplayers,//最大玩家,[1,64]
			   char TickRate//TR 默认15
		   )
	{
		//maxplayers和TickRate还在搞，不会
		wstring CMDLINE = EXECFILE;
		//CMDLINE += L"dontstarve_dedicated_server_nullrenderer.exe ";

		//参数合成前部，嫌太长可以不看
		struct ARG
		{
			wstring a1;
			wstring a2;
			wstring a3;
			wstring a4;
			wstring a5;
			wstring a6;
			wstring a7;
			wstring a8;
			wstring a9;
		};
		ARG ARG_o =
		{
			L"-persistent_storage_root " ,
			L"-conf_dir " ,
			L"-cluster ",
			L"-Shard ",
			L"-token ",
			L"-backup_logs ",
			L"-offline ",
			L"-maxplayers ",
			L"-tickrate "
		};

		ARG realarg =
		{
			rs,
			conf_dir,
			CLUSTER,
			SHARD,
			token,
			LOGBACKUP,
		};
		wstring* p1 = &ARG_o.a1;
		wstring* p2 = &realarg.a1;
		wstring* p_cmd = &CMDLINE;
		for (char i = 0; i <= 5; i++)
		{

			//指针大法

			if (*p2 != L"")
			{
				*p_cmd += *p1;
				*p_cmd += L" ";
				*p_cmd += *p2;
				*p_cmd += L" ";
			}

			p1++;
			p2++;
		}
		p1 = nullptr;
		p2 = nullptr;
		if (offline)
		{
			CMDLINE += ARG_o.a7;
			CMDLINE += L"";
		}

		_SECURITY_ATTRIBUTES SA_1
		{
			sizeof(SA_1),
			NULL,
			false
		};


		//maxplayers和tickrate缺省代用

		wchar_t charCmdLine[MAX_PATH + 250];
		lstrcpyW(charCmdLine, CMDLINE.c_str());
		if (
			CreateProcessW(
				0,
				charCmdLine,
				&SA_1,
				&SA_1,
				false,
				CREATE_NEW_CONSOLE | CREATE_UNICODE_ENVIRONMENT,
				0,
				0,
				&si_SV,
				&pi_SV
			)
			)
			return pi_SV.dwProcessId;
		else
			return 0;


	}
	public:_DSTServer(wchar_t* rs, wchar_t* confdir, wchar_t* cluster, wchar_t* shard, wchar_t* token,
		wchar_t* logbackup, wchar_t* execfile, bool offline, char maxplayers, char tr, wchar_t* wSvTitle)
	{
		arg =
		{
			rs,confdir,cluster,shard,token,logbackup,execfile,offline,maxplayers,tr,wSvTitle
		};
		ZeroMemory(&si_SV, sizeof(si_SV));
		ZeroMemory(&pi_SV, sizeof(pi_SV));
		GetStartupInfoW(&si_SV);
		si_SV.wShowWindow = SW_SHOW;
		si_SV.dwFlags = STARTF_USESHOWWINDOW;
		call_sv(
			arg.a1,
			arg.a2,
			arg.a3,
			arg.a4,
			arg.a5,
			arg.a6,
			arg.a7,
			arg.a8,
			arg.a9,
			arg.a10);

	}
	public:~_DSTServer()
	{
		TerminateProcess(pi_SV.hProcess, 0);
	}
	};

	public class maskclassServer
	{
		
	public:maskclassServer
		(
			String ^ rs,
			String ^ confdir,
			String ^ cluster,
			String ^ shard,
			String ^ token,
			String ^ logbacup,
			String ^ execfile,
			bool offline,
			char maxplayers,
			char tr,
			String^ SvTitle
		)
		{
			_DSTServer DstServer(StringToChar(rs), StringToChar(confdir), StringToChar(cluster), StringToChar(shard),
				StringToChar(token), StringToChar(logbacup), StringToChar(execfile), offline, maxplayers,
				tr, StringToChar(SvTitle));
		}
	};


