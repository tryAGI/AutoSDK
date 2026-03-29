//HintName: G.Models.DeepInfraModelProvider.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum DeepInfraModelProvider
    {
        /// <summary>
        /// 
        /// </summary>
        Deepinfra,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class DeepInfraModelProviderExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this DeepInfraModelProvider value)
        {
            return value switch
            {
                DeepInfraModelProvider.Deepinfra => "deepinfra",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static DeepInfraModelProvider? ToEnum(string value)
        {
            return value switch
            {
                "deepinfra" => DeepInfraModelProvider.Deepinfra,
                _ => null,
            };
        }
    }
}