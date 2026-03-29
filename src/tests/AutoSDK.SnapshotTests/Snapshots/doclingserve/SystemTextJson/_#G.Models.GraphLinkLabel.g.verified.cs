//HintName: G.Models.GraphLinkLabel.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// GraphLinkLabel.
    /// </summary>
    public enum GraphLinkLabel
    {
        /// <summary>
        /// 
        /// </summary>
        ToChild,
        /// <summary>
        /// 
        /// </summary>
        ToKey,
        /// <summary>
        /// 
        /// </summary>
        ToParent,
        /// <summary>
        /// 
        /// </summary>
        ToValue,
        /// <summary>
        /// 
        /// </summary>
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