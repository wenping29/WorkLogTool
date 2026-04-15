using System;
using System.Globalization;
using System.Windows.Data;

namespace WorkLogTool;

/// <summary>
/// 值转换器：将数值加1，用于序号显示（从0开始转换为从1开始）
/// </summary>
public class IncrementConverter : IValueConverter
{
    public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
    {
        if (value is int intValue)
        {
            return intValue + 1;
        }
        return value;
    }

    public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
    {
        throw new NotImplementedException();
    }
}
