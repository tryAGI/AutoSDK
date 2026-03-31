//HintName: G.Models.PickExpressiveVideoExpressivePublicAllowedAttributesStatus.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum PickExpressiveVideoExpressivePublicAllowedAttributesStatus
    {
        /// <summary>
        /// 
        /// </summary>
        Created,
        /// <summary>
        /// 
        /// </summary>
        Done,
        /// <summary>
        /// 
        /// </summary>
        Error,
        /// <summary>
        /// 
        /// </summary>
        Rejected,
        /// <summary>
        /// 
        /// </summary>
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