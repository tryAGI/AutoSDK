//HintName: G.Models.PickExpressiveVideoExpressivePublicAllowedAttributesStatus.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum PickExpressiveVideoExpressivePublicAllowedAttributesStatus
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="created")]
        Created,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="done")]
        Done,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="error")]
        Error,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="rejected")]
        Rejected,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="started")]
        Started,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class PickExpressiveVideoExpressivePublicAllowedAttributesStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PickExpressiveVideoExpressivePublicAllowedAttributesStatus value)
        {
            return value switch
            {
                PickExpressiveVideoExpressivePublicAllowedAttributesStatus.Created => "created",
                PickExpressiveVideoExpressivePublicAllowedAttributesStatus.Done => "done",
                PickExpressiveVideoExpressivePublicAllowedAttributesStatus.Error => "error",
                PickExpressiveVideoExpressivePublicAllowedAttributesStatus.Rejected => "rejected",
                PickExpressiveVideoExpressivePublicAllowedAttributesStatus.Started => "started",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PickExpressiveVideoExpressivePublicAllowedAttributesStatus? ToEnum(string value)
        {
            return value switch
            {
                "created" => PickExpressiveVideoExpressivePublicAllowedAttributesStatus.Created,
                "done" => PickExpressiveVideoExpressivePublicAllowedAttributesStatus.Done,
                "error" => PickExpressiveVideoExpressivePublicAllowedAttributesStatus.Error,
                "rejected" => PickExpressiveVideoExpressivePublicAllowedAttributesStatus.Rejected,
                "started" => PickExpressiveVideoExpressivePublicAllowedAttributesStatus.Started,
                _ => null,
            };
        }
    }
}