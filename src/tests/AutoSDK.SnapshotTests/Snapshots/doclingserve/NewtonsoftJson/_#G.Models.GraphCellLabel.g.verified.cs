//HintName: G.Models.GraphCellLabel.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// GraphCellLabel.
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum GraphCellLabel
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="checkbox")]
        Checkbox,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="key")]
        Key,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="unspecified")]
        Unspecified,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="value")]
        Value,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GraphCellLabelExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GraphCellLabel value)
        {
            return value switch
            {
                GraphCellLabel.Checkbox => "checkbox",
                GraphCellLabel.Key => "key",
                GraphCellLabel.Unspecified => "unspecified",
                GraphCellLabel.Value => "value",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GraphCellLabel? ToEnum(string value)
        {
            return value switch
            {
                "checkbox" => GraphCellLabel.Checkbox,
                "key" => GraphCellLabel.Key,
                "unspecified" => GraphCellLabel.Unspecified,
                "value" => GraphCellLabel.Value,
                _ => null,
            };
        }
    }
}