# SQLite �ַ����л���ʾ����

![](https://github.com/surfsky/SQLiteEncoding/blob/master/snap?raw=true)
- /���� Sqlite ���ݿ�
- /��ʾ�������ݿ��
- /��ʾ���ݿ������
- /���л��ַ������ʽ���޸� System.Data.SQLite Դ��֧���л��ַ�����
- /Ū��С�����ݲ鿴����



# �ο�����
```
SQLiteConvert.Enc = Encoding.GetEncoding("gb2312"); // �����ַ���
using (SQLiteConnection conn = new SQLiteConnection(GetConnectionString()))
{
    conn.Open();
    this.grid.DataSource = SQLiteHelper.GetTableData(conn, name);
}
```


# �޸� System.Data.SQLite Դ��ķ���

1. ����Դ�룺http://system.data.sqlite.org/index.html/doc/trunk/www/downloads.wiki
2. �򿪹��̣��磺SQLite.NET.2017.sln
3. �ҵ�SQLiteConvert.cs����ʼ�ع���

  - ����_utf8->Enc������Ϊ���У����£�
    ```
    ԭ���� private static Encoding _utf8 = new UTF8Encoding();
    ����Ϊ public static Encoding Enc = new UTF8Encoding();
    ```
  - ����UTF8ToString() -> PtrToString()
  - ����ToUTF8() -> ToBytes()
  
4. ѡ����ĿSystem.Data.SQLite.2017, ѡ��Release����


# ����

- �����и���ĿҪ�ԽӺ�����բ�豸��������sqlite��Ϊ���ݿ�洢��
- ���������ı���c++��gb2312�洢�ģ���sqliteĬ������utf8����洢�ģ�System.Data.SQLiteĬ��Ҳ����utf8���д�ȡ�ġ�
- �����ȡ������������ַ��������롣
- �������ϵ����ϣ������������Ѿã�����ʹٷ��ƺ�Ҳû��֧�ֶ��ַ������뷨��
- û�취��ֻ����Դ������޸ģ������֧�ֶ��ַ�����
- ʾ���������ṩ�� System.Data.SQLite.dll ������ .Net framework 4.5��֧�ֶ��ַ�����

# Author

https://www.github.com/surfsky/SQLiteEncoding
