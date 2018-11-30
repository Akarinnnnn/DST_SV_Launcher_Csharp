#include "stdafx.h"


#ifdef EXPORT
#define SVLAUNCHER_API __declspec(dllexport)
#else
#define SVLAUNCHER_API __declspec(dllimport)
#endif
namespace SVLauncherDll
{
	__declspec(dllexport) struct svarg;

	__declspec(dllexport) wchar_t* _cdecl getarg(svarg a);

	__declspec(dllexport) wchar_t* _cdecl GetCurDir(svarg a);

	__declspec(dllexport) PROCESS_INFORMATION* _cdecl _callsv(wchar_t CmdLine[250], wchar_t CurDir[MAX_PATH]);

	__declspec(dllexport) PROCESS_INFORMATION* _cdecl CallSv(svarg a);

	__declspec(dllexport) bool  _cdecl killsv(PROCESS_INFORMATION a);
}