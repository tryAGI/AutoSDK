//HintName: G.Models.DeployType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum DeployType
    {
        /// <summary>
        /// 
        /// </summary>
        Legacy,
        /// <summary>
        /// 
        /// </summary>
        Llm,
        /// <summary>
        /// 
        /// </summary>
        Lora,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class DeployTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this DeployType value)
        {
            return value switch
            {
                DeployType.Legacy => "legacy",
                DeployType.Llm => "llm",
                DeployType.Lora => "lora",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static DeployType? ToEnum(string value)
        {
            return value switch
            {
                "legacy" => DeployType.Legacy,
                "llm" => DeployType.Llm,
                "lora" => DeployType.Lora,
                _ => null,
            };
        }
    }
}