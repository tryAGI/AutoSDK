//HintName: G.Models.FilterNumberTypeColumnOnCallTableOperator.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// This is the operator to use for the filter.<br/>
    /// For number type columns, the operator must be "=", "&gt;", "&lt;", "&gt;=", "&lt;="<br/>
    /// Example: "=" or "&gt;" or "&lt;" or "&gt;=" or "&lt;="
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum FilterNumberTypeColumnOnCallTableOperator
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="eq")]
        Eq,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="gt")]
        Gt,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="gte")]
        Gte,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="lt")]
        Lt,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="lte")]
        Lte,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="neq")]
        Neq,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class FilterNumberTypeColumnOnCallTableOperatorExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this FilterNumberTypeColumnOnCallTableOperator value)
        {
            return value switch
            {
                FilterNumberTypeColumnOnCallTableOperator.Eq => "eq",
                FilterNumberTypeColumnOnCallTableOperator.Gt => "gt",
                FilterNumberTypeColumnOnCallTableOperator.Gte => "gte",
                FilterNumberTypeColumnOnCallTableOperator.Lt => "lt",
                FilterNumberTypeColumnOnCallTableOperator.Lte => "lte",
                FilterNumberTypeColumnOnCallTableOperator.Neq => "neq",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static FilterNumberTypeColumnOnCallTableOperator? ToEnum(string value)
        {
            return value switch
            {
                "eq" => FilterNumberTypeColumnOnCallTableOperator.Eq,
                "gt" => FilterNumberTypeColumnOnCallTableOperator.Gt,
                "gte" => FilterNumberTypeColumnOnCallTableOperator.Gte,
                "lt" => FilterNumberTypeColumnOnCallTableOperator.Lt,
                "lte" => FilterNumberTypeColumnOnCallTableOperator.Lte,
                "neq" => FilterNumberTypeColumnOnCallTableOperator.Neq,
                _ => null,
            };
        }
    }
}