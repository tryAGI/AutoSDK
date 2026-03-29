//HintName: G.Models.GetIntegrationsType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Default Value: all
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum GetIntegrationsType
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="all")]
        All,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="organisation")]
        Organisation,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="workspace")]
        Workspace,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GetIntegrationsTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetIntegrationsType value)
        {
            return value switch
            {
                GetIntegrationsType.All => "all",
                GetIntegrationsType.Organisation => "organisation",
                GetIntegrationsType.Workspace => "workspace",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetIntegrationsType? ToEnum(string value)
        {
            return value switch
            {
                "all" => GetIntegrationsType.All,
                "organisation" => GetIntegrationsType.Organisation,
                "workspace" => GetIntegrationsType.Workspace,
                _ => null,
            };
        }
    }
}