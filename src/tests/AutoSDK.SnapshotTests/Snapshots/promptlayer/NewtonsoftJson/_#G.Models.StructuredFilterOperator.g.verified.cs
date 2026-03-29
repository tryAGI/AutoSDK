//HintName: G.Models.StructuredFilterOperator.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The comparison operator.
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum StructuredFilterOperator
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="after")]
        After,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="before")]
        Before,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="between")]
        Between,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="contains")]
        Contains,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="ends_with")]
        EndsWith,
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
        [global::System.Runtime.Serialization.EnumMember(Value="in")]
        In,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="is")]
        Is,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="is_empty")]
        IsEmpty,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="is_false")]
        IsFalse,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="is_not")]
        IsNot,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="is_not_empty")]
        IsNotEmpty,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="is_not_null")]
        IsNotNull,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="is_null")]
        IsNull,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="is_true")]
        IsTrue,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="key_contains")]
        KeyContains,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="key_equals")]
        KeyEquals,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="key_not_equals")]
        KeyNotEquals,
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
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="not_contains")]
        NotContains,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="not_in")]
        NotIn,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="starts_with")]
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