//HintName: G.Models.ReposListCollaboratorsAffiliation.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Default Value: all
    /// </summary>
    public enum ReposListCollaboratorsAffiliation
    {
        /// <summary>
        /// 
        /// </summary>
        All,
        /// <summary>
        /// 
        /// </summary>
        Direct,
        /// <summary>
        /// 
        /// </summary>
        Outside,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ReposListCollaboratorsAffiliationExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ReposListCollaboratorsAffiliation value)
        {
            return value switch
            {
                ReposListCollaboratorsAffiliation.All => "all",
                ReposListCollaboratorsAffiliation.Direct => "direct",
                ReposListCollaboratorsAffiliation.Outside => "outside",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ReposListCollaboratorsAffiliation? ToEnum(string value)
        {
            return value switch
            {
                "all" => ReposListCollaboratorsAffiliation.All,
                "direct" => ReposListCollaboratorsAffiliation.Direct,
                "outside" => ReposListCollaboratorsAffiliation.Outside,
                _ => null,
            };
        }
    }
}