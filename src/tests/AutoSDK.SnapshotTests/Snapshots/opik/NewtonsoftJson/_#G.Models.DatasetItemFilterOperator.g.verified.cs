//HintName: G.Models.DatasetItemFilterOperator.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum DatasetItemFilterOperator
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="!=")]
        Neq,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="<")]
        Lt,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="<=")]
        Lte,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="=")]
        Eq,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value=">")]
        Gt,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value=">=")]
        Gte,
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
        [global::System.Runtime.Serialization.EnumMember(Value="is_empty")]
        IsEmpty,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="is_not_empty")]
        IsNotEmpty,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="not_contains")]
        NotContains,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="starts_with")]
        StartsWith,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class DatasetItemFilterOperatorExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this DatasetItemFilterOperator value)
        {
            return value switch
            {
                DatasetItemFilterOperator.Neq => "!=",
                DatasetItemFilterOperator.Lt => "<",
                DatasetItemFilterOperator.Lte => "<=",
                DatasetItemFilterOperator.Eq => "=",
                DatasetItemFilterOperator.Gt => ">",
                DatasetItemFilterOperator.Gte => ">=",
                DatasetItemFilterOperator.Contains => "contains",
                DatasetItemFilterOperator.EndsWith => "ends_with",
                DatasetItemFilterOperator.IsEmpty => "is_empty",
                DatasetItemFilterOperator.IsNotEmpty => "is_not_empty",
                DatasetItemFilterOperator.NotContains => "not_contains",
                DatasetItemFilterOperator.StartsWith => "starts_with",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static DatasetItemFilterOperator? ToEnum(string value)
        {
            return value switch
            {
                "!=" => DatasetItemFilterOperator.Neq,
                "<" => DatasetItemFilterOperator.Lt,
                "<=" => DatasetItemFilterOperator.Lte,
                "=" => DatasetItemFilterOperator.Eq,
                ">" => DatasetItemFilterOperator.Gt,
                ">=" => DatasetItemFilterOperator.Gte,
                "contains" => DatasetItemFilterOperator.Contains,
                "ends_with" => DatasetItemFilterOperator.EndsWith,
                "is_empty" => DatasetItemFilterOperator.IsEmpty,
                "is_not_empty" => DatasetItemFilterOperator.IsNotEmpty,
                "not_contains" => DatasetItemFilterOperator.NotContains,
                "starts_with" => DatasetItemFilterOperator.StartsWith,
                _ => null,
            };
        }
    }
}