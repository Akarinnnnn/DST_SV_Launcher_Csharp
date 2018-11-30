// SVLauncherDll.cpp : 定义 DLL 应用程序的导出函数。
//

#include "stdafx.h"
#include <string>
#include "Winnt.h"
#include "SVLauncherDll.h"
#pragma region A
#define EXPORT
using namespace std;

PROCESS_INFORMATION pi;
namespace SVLauncherDll
{
	__declspec(dllexport)  typedef struct SVLauncherDll::svarg
	{
		LPWSTR execfile = (wchar_t*)L"dontstarve_dedicated_server_nullrenderer.exe";
		LPWSTR cluster = (wchar_t*)L"Cluster_1";
		LPWSTR shard = (wchar_t*)L"Master";
		LPWSTR rootstroage = nullptr;
		LPWSTR conf_dir = nullptr;
		LPWSTR log_backup_dir = nullptr;
		LPWSTR Token = nullptr;
		LPWSTR CurDir = (wchar_t*)L"";
		bool offline = 1;
		char maxplayers = 4;
		char tickrate = 15;
		wchar_t* Con_Title = (wchar_t*)L"";

	};
	svarg Defaultarg;
	__declspec(dllexport)  wchar_t* SVLauncherDll::getarg(svarg a)
	{

		struct arg {
			LPWSTR a1;
			LPWSTR a2;
			LPWSTR a3;
			LPWSTR a4;
			LPWSTR a5;
			LPWSTR a6;
			LPWSTR a7;
			LPWSTR a8;
			LPWSTR a9;
		};
		arg ARG_o =
		{
			(wchar_t*)L"-cluster ",
			(wchar_t*)L"-Shard ",
			(wchar_t*)L"-persistent_storage_root " ,
			(wchar_t*)L"-conf_dir " ,
			(wchar_t*)L"-backup_logs ",
			(wchar_t*)L"-token ",
			(wchar_t*)L"-offline ",
			(wchar_t*)L"-maxplayers ",
			(wchar_t*)L"-tickrate "
		};
		wstring CMDLINE;
		CMDLINE += a.execfile;
		LPWSTR p1 = ARG_o.a1;
		LPWSTR p2 = a.cluster;

		for (char i = 0; i <= 5; i++)
		{

			//指针大法

			if (p2 != L"")
			{
				CMDLINE += *p1;
				CMDLINE += L" ";
				CMDLINE += *p2;
				CMDLINE += L" ";
			}

			p1++;
			p2++;
		}
		p1 = nullptr;
		p2 = nullptr;
		static wchar_t* ret;
		ret = (wchar_t*)L"";
		lstrcpyW(ret, CMDLINE.c_str());
		return ret;
	}
	__declspec(dllexport) wchar_t* SVLauncherDll::GetCurDir(svarg a)
	{
		static wchar_t buff[500];
		lstrcpyW(buff, a.execfile);
		for (int i = MAX_PATH; i >= 0; i--)
		{
			if (buff[i] == L'\\')
			{
				for (int j = i; buff[j] != L'\0'; j++)
				{
					buff[j] = L'\0';
				}
			}
		}
		return buff;
	}
	__declspec(dllexport) PROCESS_INFORMATION* SVLauncherDll::_callsv(wchar_t CmdLine[250], wchar_t CurDir[MAX_PATH])
	{
		SECURITY_ATTRIBUTES sa;
		ZeroMemory(&sa, 0);
		sa = {
			sizeof(sa),
			NULL,
			false
		};
		STARTUPINFOW si;
		ZeroMemory(&si, 0);
		ZeroMemory(&pi, 0);
		si.cb = (sizeof(si) / 4);
		CreateProcessW(
			nullptr,
			CmdLine,
			&sa,
			&sa,
			false,
			NULL,
			NULL,
			CurDir,
			&si,
			&pi);
		return(&pi);
	}
	__declspec(dllexport) bool SVLauncherDll::killsv(PROCESS_INFORMATION a)
	{
		TerminateThread(a.hThread, 0);
		return TerminateProcess(a.hProcess, 0);
	}
	__declspec(dllexport) PROCESS_INFORMATION* SVLauncherDll::CallSv(svarg a)
	{
		return _callsv(getarg(a), GetCurDir(a));
	}
}

#pragma endregion
