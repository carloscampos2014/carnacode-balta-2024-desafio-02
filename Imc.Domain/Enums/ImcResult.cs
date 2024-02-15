using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Imc.Domain.Enums;

public enum ImcResult
{
    [Description("🍏🥦 Abaixo do Peso")]
    Magreza = 0,

    [Description("😊🎉 Peso Ideal")]
    Normal = 1,

    [Description("🏋️‍🥗 Acima do Peso")]
    Sobrepeso = 2,

    [Description("🏃‍🍇 Obesidade")]
    Obesidade = 3,

    [Description("⚠️💡 Obesidade Grave")]
    ObsesidadeGrave = 4,
}
