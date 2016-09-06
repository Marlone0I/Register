# Register

用C#写的一个[迅捷PDF转换器客户端](http://app.xunjiepdf.com/)的注册机。

*注：* 未编译

`C#`  `VS2015`
****************
算法代码如下：
```
public static string get_reg_code(string machine_code)
{
    long num = Convert.ToInt64(machine_code);
    for (int i = 0; i < 100; i++)
    {
        string text = (num * 2L).ToString();
        if (text.Length <= 12)
        {
            num = Convert.ToInt64(text);
        }
        else
        {
            num = Convert.ToInt64(text.Substring(0, 12));
        }
    }
    return num.ToString();
}
```
