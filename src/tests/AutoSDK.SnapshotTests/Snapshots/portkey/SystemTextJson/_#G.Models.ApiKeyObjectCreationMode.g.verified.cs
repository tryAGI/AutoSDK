//HintName: G.Models.ApiKeyObjectCreationMode.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Example: ui
    /// </summary>
    public enum ApiKeyObjectCreationMode
    {
        /// <summary>
        /// 
        /// </summary>
        Api,
        /// <summary>
        /// 
        /// </summary>
        Auto,
        /// <summary>
        /// 
        /// </summary>
        Ui,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ApiKeyObjectCreationModeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ApiKeyObjectCreationMode value)
        {
            return value switch
            {
                ApiKeyObjectCreationMode.Api => "api",
                ApiKeyObjectCreationMode.Auto => "auto",
                ApiKeyObjectCreationMode.Ui => "ui",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ApiKeyObjectCreationMode? ToEnum(string value)
        {
            return value switch
            {
                "api" => ApiKeyObjectCreationMode.Api,
                "auto" => ApiKeyObjectCreationMode.Auto,
                "ui" => ApiKeyObjectCreationMode.Ui,
                _ => null,
            };
        }
    }
}