//HintName: G.Models.JSONKeysParametersOperator.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Operator to use for key checking<br/>
    /// Default Value: any
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum JSONKeysParametersOperator
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="all")]
        All,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="any")]
        Any,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="none")]
        None,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class JSONKeysParametersOperatorExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this JSONKeysParametersOperator value)
        {
            return value switch
            {
                JSONKeysParametersOperator.All => "all",
                JSONKeysParametersOperator.Any => "any",
                JSONKeysParametersOperator.None => "none",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static JSONKeysParametersOperator? ToEnum(string value)
        {
            return value switch
            {
                "all" => JSONKeysParametersOperator.All,
                "any" => JSONKeysParametersOperator.Any,
                "none" => JSONKeysParametersOperator.None,
                _ => null,
            };
        }
    }
}