//HintName: G.Models.CodespaceLocation.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The initally assigned location of a new codespace.
    /// <br/>Example: WestUs2
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum CodespaceLocation
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="EastUs")]
        EastUs,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="SouthEastAsia")]
        SouthEastAsia,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="WestEurope")]
        WestEurope,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="WestUs2")]
        WestUs2,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CodespaceLocationExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CodespaceLocation value)
        {
            return value switch
            {
                CodespaceLocation.EastUs => "EastUs",
                CodespaceLocation.SouthEastAsia => "SouthEastAsia",
                CodespaceLocation.WestEurope => "WestEurope",
                CodespaceLocation.WestUs2 => "WestUs2",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CodespaceLocation ToEnum(string value)
        {
            return value switch
            {
                "EastUs" => CodespaceLocation.EastUs,
                "SouthEastAsia" => CodespaceLocation.SouthEastAsia,
                "WestEurope" => CodespaceLocation.WestEurope,
                "WestUs2" => CodespaceLocation.WestUs2,
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
    }
}