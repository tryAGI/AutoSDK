//HintName: G.Models.UpdateToolTemplateDTOProvider.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum UpdateToolTemplateDTOProvider
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="function")]
        Function,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="gohighlevel")]
        Gohighlevel,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="make")]
        Make,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class UpdateToolTemplateDTOProviderExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UpdateToolTemplateDTOProvider value)
        {
            return value switch
            {
                UpdateToolTemplateDTOProvider.Function => "function",
                UpdateToolTemplateDTOProvider.Gohighlevel => "gohighlevel",
                UpdateToolTemplateDTOProvider.Make => "make",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UpdateToolTemplateDTOProvider? ToEnum(string value)
        {
            return value switch
            {
                "function" => UpdateToolTemplateDTOProvider.Function,
                "gohighlevel" => UpdateToolTemplateDTOProvider.Gohighlevel,
                "make" => UpdateToolTemplateDTOProvider.Make,
                _ => null,
            };
        }
    }
}