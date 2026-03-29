//HintName: G.Models.DatasetItemFilterOperator.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum DatasetItemFilterOperator
    {
        /// <summary>
        /// 
        /// </summary>
        Neq,
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
        Contains,
        /// <summary>
        /// 
        /// </summary>
        EndsWith,
        /// <summary>
        /// 
        /// </summary>
        IsEmpty,
        /// <summary>
        /// 
        /// </summary>
        IsNotEmpty,
        /// <summary>
        /// 
        /// </summary>
        NotContains,
        /// <summary>
        /// 
        /// </summary>
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