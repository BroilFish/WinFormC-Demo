// ���� ifdef ���Ǵ���ʹ�� DLL �������򵥵�
// ��ı�׼�������� DLL �е������ļ��������������϶���� MYNATIVEDLL_EXPORTS
// ���ű���ġ���ʹ�ô� DLL ��
// �κ�������Ŀ�ϲ�Ӧ����˷��š�������Դ�ļ��а������ļ����κ�������Ŀ���Ὣ
// MYNATIVEDLL_API ������Ϊ�Ǵ� DLL ����ģ����� DLL ���ô˺궨���
// ������Ϊ�Ǳ������ġ�
#ifdef MYNATIVEDLL_EXPORTS
#define MYNATIVEDLL_API __declspec(dllexport)
#else
#define MYNATIVEDLL_API __declspec(dllimport)
#endif

// �����Ǵ� MyNativeDll.dll ������
class MYNATIVEDLL_API CMyNativeDll {
public:
	CMyNativeDll(void);
	// TODO: �ڴ�������ķ�����
};

extern MYNATIVEDLL_API int nMyNativeDll;

MYNATIVEDLL_API int fnMyNativeDll(void);
