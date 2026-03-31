//HintName: G.Models.A2eModel.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum A2eModel
    {
        /// <summary>
        /// 
        /// </summary>
        BaselineDefault,
        /// <summary>
        /// 
        /// </summary>
        Finetuned,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class A2eModelExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this A2eModel value)
        {
            return value switch
            {
                A2eModel.BaselineDefault => "Baseline (default)",
                A2eModel.Finetuned => "Finetuned",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static A2eModel? ToEnum(string value)
        {
            return value switch
            {
                "Baseline (default)" => A2eModel.BaselineDefault,
                "Finetuned" => A2eModel.Finetuned,
                _ => null,
            };
        }
    }
}