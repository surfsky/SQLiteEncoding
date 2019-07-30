# SQLite 字符集切换演示程序

![](https://github.com/surfsky/SQLiteEncoding/blob/master/snap.png?raw=true)
- /加载 Sqlite 数据库
- /显示所有数据库表
- /显示数据库表数据
- /可切换字符编码格式（修改 System.Data.SQLite 源码支持切换字符集）
- /弄成小型数据查看工具



# 参考代码
```
SQLiteConvert.Enc = Encoding.GetEncoding("gb2312"); // 更改字符集
using (SQLiteConnection conn = new SQLiteConnection(GetConnectionString()))
{
    conn.Open();
    this.grid.DataSource = SQLiteHelper.GetTableData(conn, name);
}
```


# 修改 System.Data.SQLite 源码的方法

1. 下载源码：http://system.data.sqlite.org/index.html/doc/trunk/www/downloads.wiki
2. 打开工程，如：SQLite.NET.2017.sln
3. 找到SQLiteConvert.cs，开始重构：

  - 更名_utf8->Enc，并改为公有，如下：
    ```
    原代码 private static Encoding _utf8 = new UTF8Encoding();
    更改为 public static Encoding Enc = new UTF8Encoding();
    ```
  - 更名UTF8ToString() -> PtrToString()
  - 更名ToUTF8() -> ToBytes()
  
4. 选择项目System.Data.SQLite.2017, 选择Release编译


# 来由

- 近期有个项目要对接海康道闸设备，海康用sqlite作为数据库存储。
- 海康储存文本是c++用gb2312存储的，而sqlite默认是以utf8编码存储的，System.Data.SQLite默认也是以utf8进行存取的。
- 结果读取出来后的中文字符都是乱码。
- 查了网上的资料，这个问题存在已久，歪果仁官方似乎也没有支持多字符集的想法。
- 没办法，只能找源码进行修改，令其可支持多字符集。
- 示例程序中提供的 System.Data.SQLite.dll 环境是 .Net framework 4.5，支持多字符集。

# Author

https://www.github.com/surfsky/SQLiteEncoding
