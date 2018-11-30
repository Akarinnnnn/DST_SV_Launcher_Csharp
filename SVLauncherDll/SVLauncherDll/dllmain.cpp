// dllmain.cpp : 定义 DLL 应用程序的入口点。
#include "stdafx.h"
#include <iostream>
using namespace std;
BOOL APIENTRY DllMain( HMODULE hModule,
                       DWORD  ul_reason_for_call,
                       LPVOID lpReserved
                     )
{
    switch (ul_reason_for_call)
    {
    case DLL_PROCESS_ATTACH:
		//wcout << L"Process Attached." << endl;
    case DLL_THREAD_ATTACH:
		//wcout << L"Thread Attached." << endl;
    case DLL_THREAD_DETACH:
		//wcout << L"Thread Deathed." << endl;
    case DLL_PROCESS_DETACH:
		//wcout << L"Process Deathed." << endl;
        break;
    }
    return TRUE;
}

