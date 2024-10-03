//HintName: G.Models.WhereFilterOperator.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// operator to use<br/>
    /// Example: GreaterThanEqual
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum WhereFilterOperator
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="And")]
        And,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="Or")]
        Or,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="Equal")]
        Equal,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="Like")]
        Like,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="NotEqual")]
        NotEqual,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="GreaterThan")]
        GreaterThan,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="GreaterThanEqual")]
        GreaterThanEqual,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="LessThan")]
        LessThan,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="LessThanEqual")]
        LessThanEqual,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="WithinGeoRange")]
        WithinGeoRange,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="IsNull")]
        IsNull,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="ContainsAny")]
        ContainsAny,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="ContainsAll")]
        ContainsAll,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class WhereFilterOperatorExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WhereFilterOperator value)
        {
            return value switch
            {
                WhereFilterOperator.And => "And",
                WhereFilterOperator.Or => "Or",
                WhereFilterOperator.Equal => "Equal",
                WhereFilterOperator.Like => "Like",
                WhereFilterOperator.NotEqual => "NotEqual",
                WhereFilterOperator.GreaterThan => "GreaterThan",
                WhereFilterOperator.GreaterThanEqual => "GreaterThanEqual",
                WhereFilterOperator.LessThan => "LessThan",
                WhereFilterOperator.LessThanEqual => "LessThanEqual",
                WhereFilterOperator.WithinGeoRange => "WithinGeoRange",
                WhereFilterOperator.IsNull => "IsNull",
                WhereFilterOperator.ContainsAny => "ContainsAny",
                WhereFilterOperator.ContainsAll => "ContainsAll",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WhereFilterOperator? ToEnum(string value)
        {
            return value switch
            {
                "And" => WhereFilterOperator.And,
                "Or" => WhereFilterOperator.Or,
                "Equal" => WhereFilterOperator.Equal,
                "Like" => WhereFilterOperator.Like,
                "NotEqual" => WhereFilterOperator.NotEqual,
                "GreaterThan" => WhereFilterOperator.GreaterThan,
                "GreaterThanEqual" => WhereFilterOperator.GreaterThanEqual,
                "LessThan" => WhereFilterOperator.LessThan,
                "LessThanEqual" => WhereFilterOperator.LessThanEqual,
                "WithinGeoRange" => WhereFilterOperator.WithinGeoRange,
                "IsNull" => WhereFilterOperator.IsNull,
                "ContainsAny" => WhereFilterOperator.ContainsAny,
                "ContainsAll" => WhereFilterOperator.ContainsAll,
                _ => null,
            };
        }
    }
}