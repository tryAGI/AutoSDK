//HintName: G.Models.WhereFilterOperator.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// operator to use<br/>
    /// Example: GreaterThanEqual
    /// </summary>
    public enum WhereFilterOperator
    {
        /// <summary>
        /// 
        /// </summary>
        And,
        /// <summary>
        /// 
        /// </summary>
        Or,
        /// <summary>
        /// 
        /// </summary>
        Equal,
        /// <summary>
        /// 
        /// </summary>
        Like,
        /// <summary>
        /// 
        /// </summary>
        NotEqual,
        /// <summary>
        /// 
        /// </summary>
        GreaterThan,
        /// <summary>
        /// 
        /// </summary>
        GreaterThanEqual,
        /// <summary>
        /// 
        /// </summary>
        LessThan,
        /// <summary>
        /// 
        /// </summary>
        LessThanEqual,
        /// <summary>
        /// 
        /// </summary>
        WithinGeoRange,
        /// <summary>
        /// 
        /// </summary>
        IsNull,
        /// <summary>
        /// 
        /// </summary>
        ContainsAny,
        /// <summary>
        /// 
        /// </summary>
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