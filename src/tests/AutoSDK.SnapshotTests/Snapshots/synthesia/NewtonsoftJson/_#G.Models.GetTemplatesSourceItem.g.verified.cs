//HintName: G.Models.GetTemplatesSourceItem.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum GetTemplatesSourceItem
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="synthesia")]
        Synthesia,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="workspace")]
        Workspace,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GetTemplatesSourceItemExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetTemplatesSourceItem value)
        {
            return value switch
            {
                GetTemplatesSourceItem.Synthesia => "synthesia",
                GetTemplatesSourceItem.Workspace => "workspace",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetTemplatesSourceItem? ToEnum(string value)
        {
            return value switch
            {
                "synthesia" => GetTemplatesSourceItem.Synthesia,
                "workspace" => GetTemplatesSourceItem.Workspace,
                _ => null,
            };
        }
    }
}