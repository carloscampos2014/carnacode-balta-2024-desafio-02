using Imc.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Imc.Domain.Extensions;
public static class EnumExtensions
{
    public static string Description(this ImcResult result)
    {
        return result.GetEnumDescription();
    }

    private static string GetEnumDescription<TEnum>(this TEnum @enum)
    {
        var field = typeof(TEnum).GetField(@enum.ToString());

        if (field == null)
        {
            return @enum.ToString();
        }

        var description = field.GetCustomAttribute<System.ComponentModel.DescriptionAttribute>();

        if (description == null)
        {
            return @enum.ToString();
        }

        return description.Description;
    }
}
