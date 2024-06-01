//HintName: G.Models.CodespaceWithFullRepositoryLocation.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The initally assigned location of a new codespace.
    /// <br/>Example: WestUs2
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum CodespaceWithFullRepositoryLocation
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
    public static class CodespaceWithFullRepositoryLocationExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CodespaceWithFullRepositoryLocation value)
        {
            return value switch
            {
                CodespaceWithFullRepositoryLocation.EastUs => "EastUs",
                CodespaceWithFullRepositoryLocation.SouthEastAsia => "SouthEastAsia",
                CodespaceWithFullRepositoryLocation.WestEurope => "WestEurope",
                CodespaceWithFullRepositoryLocation.WestUs2 => "WestUs2",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CodespaceWithFullRepositoryLocation ToEnum(string value)
        {
            return value switch
            {
                "EastUs" => CodespaceWithFullRepositoryLocation.EastUs,
                "SouthEastAsia" => CodespaceWithFullRepositoryLocation.SouthEastAsia,
                "WestEurope" => CodespaceWithFullRepositoryLocation.WestEurope,
                "WestUs2" => CodespaceWithFullRepositoryLocation.WestUs2,
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
    }
}