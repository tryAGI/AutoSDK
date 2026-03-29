//HintName: G.Models.GraphLinkLabel.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// GraphLinkLabel.
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum GraphLinkLabel
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="to_child")]
        ToChild,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="to_key")]
        ToKey,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="to_parent")]
        ToParent,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="to_value")]
        ToValue,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="unspecified")]
        Unspecified,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GraphLinkLabelExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GraphLinkLabel value)
        {
            return value switch
            {
                GraphLinkLabel.ToChild => "to_child",
                GraphLinkLabel.ToKey => "to_key",
                GraphLinkLabel.ToParent => "to_parent",
                GraphLinkLabel.ToValue => "to_value",
                GraphLinkLabel.Unspecified => "unspecified",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GraphLinkLabel? ToEnum(string value)
        {
            return value switch
            {
                "to_child" => GraphLinkLabel.ToChild,
                "to_key" => GraphLinkLabel.ToKey,
                "to_parent" => GraphLinkLabel.ToParent,
                "to_value" => GraphLinkLabel.ToValue,
                "unspecified" => GraphLinkLabel.Unspecified,
                _ => null,
            };
        }
    }
}