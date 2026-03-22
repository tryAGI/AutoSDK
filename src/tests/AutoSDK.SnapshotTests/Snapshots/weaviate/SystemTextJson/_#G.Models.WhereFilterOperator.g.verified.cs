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
        ContainsAll,
        /// <summary>
        /// 
        /// </summary>
        ContainsAny,
        /// <summary>
        /// 
        /// </summary>
        Equal,
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
        IsNull,
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
        Like,
        /// <summary>
        /// 
        /// </summary>
        NotEqual,
        /// <summary>
        /// 
        /// </summary>
        Or,
        /// <summary>
        /// 
        /// </summary>
        WithinGeoRange,
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
                WhereFilterOperator.ContainsAll => "ContainsAll",
                WhereFilterOperator.ContainsAny => "ContainsAny",
                WhereFilterOperator.Equal => "Equal",
                WhereFilterOperator.GreaterThan => "GreaterThan",
                WhereFilterOperator.GreaterThanEqual => "GreaterThanEqual",
                WhereFilterOperator.IsNull => "IsNull",
                WhereFilterOperator.LessThan => "LessThan",
                WhereFilterOperator.LessThanEqual => "LessThanEqual",
                WhereFilterOperator.Like => "Like",
                WhereFilterOperator.NotEqual => "NotEqual",
                WhereFilterOperator.Or => "Or",
                WhereFilterOperator.WithinGeoRange => "WithinGeoRange",
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
                "ContainsAll" => WhereFilterOperator.ContainsAll,
                "ContainsAny" => WhereFilterOperator.ContainsAny,
                "Equal" => WhereFilterOperator.Equal,
                "GreaterThan" => WhereFilterOperator.GreaterThan,
                "GreaterThanEqual" => WhereFilterOperator.GreaterThanEqual,
                "IsNull" => WhereFilterOperator.IsNull,
                "LessThan" => WhereFilterOperator.LessThan,
                "LessThanEqual" => WhereFilterOperator.LessThanEqual,
                "Like" => WhereFilterOperator.Like,
                "NotEqual" => WhereFilterOperator.NotEqual,
                "Or" => WhereFilterOperator.Or,
                "WithinGeoRange" => WhereFilterOperator.WithinGeoRange,
                _ => null,
            };
        }
    }
}