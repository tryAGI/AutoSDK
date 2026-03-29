//HintName: G.Models.StructuredFilterOperator.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The comparison operator.
    /// </summary>
    public enum StructuredFilterOperator
    {
        /// <summary>
        /// 
        /// </summary>
        After,
        /// <summary>
        /// 
        /// </summary>
        Before,
        /// <summary>
        /// 
        /// </summary>
        Between,
        /// <summary>
        /// 
        /// </summary>
        Contains,
        /// <summary>
        /// 
        /// </summary>
        EndsWith,
        /// <summary>
        /// 
        /// </summary>
        Eq,
        /// <summary>
        /// 
        /// </summary>
        Gt,
        /// <summary>
        /// 
        /// </summary>
        Gte,
        /// <summary>
        /// 
        /// </summary>
        In,
        /// <summary>
        /// 
        /// </summary>
        Is,
        /// <summary>
        /// 
        /// </summary>
        IsEmpty,
        /// <summary>
        /// 
        /// </summary>
        IsFalse,
        /// <summary>
        /// 
        /// </summary>
        IsNot,
        /// <summary>
        /// 
        /// </summary>
        IsNotEmpty,
        /// <summary>
        /// 
        /// </summary>
        IsNotNull,
        /// <summary>
        /// 
        /// </summary>
        IsNull,
        /// <summary>
        /// 
        /// </summary>
        IsTrue,
        /// <summary>
        /// 
        /// </summary>
        KeyContains,
        /// <summary>
        /// 
        /// </summary>
        KeyEquals,
        /// <summary>
        /// 
        /// </summary>
        KeyNotEquals,
        /// <summary>
        /// 
        /// </summary>
        Lt,
        /// <summary>
        /// 
        /// </summary>
        Lte,
        /// <summary>
        /// 
        /// </summary>
        Neq,
        /// <summary>
        /// 
        /// </summary>
        NotContains,
        /// <summary>
        /// 
        /// </summary>
        NotIn,
        /// <summary>
        /// 
        /// </summary>
        StartsWith,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class StructuredFilterOperatorExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this StructuredFilterOperator value)
        {
            return value switch
            {
                StructuredFilterOperator.After => "after",
                StructuredFilterOperator.Before => "before",
                StructuredFilterOperator.Between => "between",
                StructuredFilterOperator.Contains => "contains",
                StructuredFilterOperator.EndsWith => "ends_with",
                StructuredFilterOperator.Eq => "eq",
                StructuredFilterOperator.Gt => "gt",
                StructuredFilterOperator.Gte => "gte",
                StructuredFilterOperator.In => "in",
                StructuredFilterOperator.Is => "is",
                StructuredFilterOperator.IsEmpty => "is_empty",
                StructuredFilterOperator.IsFalse => "is_false",
                StructuredFilterOperator.IsNot => "is_not",
                StructuredFilterOperator.IsNotEmpty => "is_not_empty",
                StructuredFilterOperator.IsNotNull => "is_not_null",
                StructuredFilterOperator.IsNull => "is_null",
                StructuredFilterOperator.IsTrue => "is_true",
                StructuredFilterOperator.KeyContains => "key_contains",
                StructuredFilterOperator.KeyEquals => "key_equals",
                StructuredFilterOperator.KeyNotEquals => "key_not_equals",
                StructuredFilterOperator.Lt => "lt",
                StructuredFilterOperator.Lte => "lte",
                StructuredFilterOperator.Neq => "neq",
                StructuredFilterOperator.NotContains => "not_contains",
                StructuredFilterOperator.NotIn => "not_in",
                StructuredFilterOperator.StartsWith => "starts_with",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static StructuredFilterOperator? ToEnum(string value)
        {
            return value switch
            {
                "after" => StructuredFilterOperator.After,
                "before" => StructuredFilterOperator.Before,
                "between" => StructuredFilterOperator.Between,
                "contains" => StructuredFilterOperator.Contains,
                "ends_with" => StructuredFilterOperator.EndsWith,
                "eq" => StructuredFilterOperator.Eq,
                "gt" => StructuredFilterOperator.Gt,
                "gte" => StructuredFilterOperator.Gte,
                "in" => StructuredFilterOperator.In,
                "is" => StructuredFilterOperator.Is,
                "is_empty" => StructuredFilterOperator.IsEmpty,
                "is_false" => StructuredFilterOperator.IsFalse,
                "is_not" => StructuredFilterOperator.IsNot,
                "is_not_empty" => StructuredFilterOperator.IsNotEmpty,
                "is_not_null" => StructuredFilterOperator.IsNotNull,
                "is_null" => StructuredFilterOperator.IsNull,
                "is_true" => StructuredFilterOperator.IsTrue,
                "key_contains" => StructuredFilterOperator.KeyContains,
                "key_equals" => StructuredFilterOperator.KeyEquals,
                "key_not_equals" => StructuredFilterOperator.KeyNotEquals,
                "lt" => StructuredFilterOperator.Lt,
                "lte" => StructuredFilterOperator.Lte,
                "neq" => StructuredFilterOperator.Neq,
                "not_contains" => StructuredFilterOperator.NotContains,
                "not_in" => StructuredFilterOperator.NotIn,
                "starts_with" => StructuredFilterOperator.StartsWith,
                _ => null,
            };
        }
    }
}