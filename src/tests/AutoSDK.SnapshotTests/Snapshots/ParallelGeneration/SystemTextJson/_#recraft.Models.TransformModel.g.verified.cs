//HintName: recraft.Models.TransformModel.g.cs

#nullable enable

namespace recraft
{
    /// <summary>
    /// 
    /// </summary>
    public enum TransformModel
    {
        /// <summary>
        /// 
        /// </summary>
        Refm1,
        /// <summary>
        /// 
        /// </summary>
        Recraft20b,
        /// <summary>
        /// 
        /// </summary>
        Recraftv3,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class TransformModelExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this TransformModel value)
        {
            return value switch
            {
                TransformModel.Refm1 => "refm1",
                TransformModel.Recraft20b => "recraft20b",
                TransformModel.Recraftv3 => "recraftv3",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static TransformModel? ToEnum(string value)
        {
            return value switch
            {
                "refm1" => TransformModel.Refm1,
                "recraft20b" => TransformModel.Recraft20b,
                "recraftv3" => TransformModel.Recraftv3,
                _ => null,
            };
        }
    }
}