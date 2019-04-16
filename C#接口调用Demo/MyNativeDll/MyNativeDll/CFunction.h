//CFunction.h
////////////////////////////////////////////
///////////////////////////////////////////
#ifndef _C_FUNCTION_H_
#define _C_FUNCTION_H_
#include "Define.h"
#include <string>
#include <istream>

struct SystemTime
{
	int year;
	int month;
	int day;
	int hour;
	int minute;
	int second;
	int millsecond;

	SystemTime & operator= (SystemTime st)
	{
		this->year = st.year;
		this->month = st.month;
		this->day = st.day;
		this->hour = st.hour;
		this->minute = st.minute;
		this->second = st.second;
		this->millsecond = st.millsecond;
		return *this;
	}
};

_EXTERN_C_ int add(int x, int y);
_EXTERN_C_ int sub(int x, int y);
_EXTERN_C_ int testChar(char * src, char * res, int nCount);
_EXTERN_C_ int testStruct(SystemTime & stSrc, SystemTime & stRes);

#endif //_C_FUNCTION_H_