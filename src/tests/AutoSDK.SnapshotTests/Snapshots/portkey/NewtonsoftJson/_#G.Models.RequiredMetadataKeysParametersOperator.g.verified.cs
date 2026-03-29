//HintName: G.Models.RequiredMetadataKeysParametersOperator.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Operator to use for key checking<br/>
    /// Default Value: all
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum RequiredMetadataKeysParametersOperator
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
    public static class RequiredMetadataKeysParametersOperatorExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RequiredMetadataKeysParametersOperator value)
        {
            return value switch
            {
                RequiredMetadataKeysParametersOperator.All => "all",
                RequiredMetadataKeysParametersOperator.Any => "any",
                RequiredMetadataKeysParametersOperator.None => "none",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RequiredMetadataKeysParametersOperator? ToEnum(string value)
        {
            return value switch
            {
                "all" => RequiredMetadataKeysParametersOperator.All,
                "any" => RequiredMetadataKeysParametersOperator.Any,
                "none" => RequiredMetadataKeysParametersOperator.None,
                _ => null,
            };
        }
    }
}