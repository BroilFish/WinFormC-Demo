//CFunction.cpp
////////////////////////////////////////////
////////////////////////////////////////////
#include "stdafx.h"
#include "CFunction.h"
#include <stdio.h>

int add(int x, int y)
{
	return x + y;
}

int sub(int x, int y)
{
	return x - y;
}

int testChar(char * src, char * res, int nCount)
{
	memcpy(res, src, sizeof(char) * nCount);
	return 1;
}

int testStruct(SystemTime & stSrc, SystemTime & stRes)
{
	stRes = stSrc;
	return 1;
}