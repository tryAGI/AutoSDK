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
        Outside,
        /// <summary>
        /// 
        /// </summary>
        Direct,
        /// <summary>
        /// 
        /// </summary>
        All,
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
                ReposListCollaboratorsAffiliation.Outside => "outside",
                ReposListCollaboratorsAffiliation.Direct => "direct",
                ReposListCollaboratorsAffiliation.All => "all",
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
                "outside" => ReposListCollaboratorsAffiliation.Outside,
                "direct" => ReposListCollaboratorsAffiliation.Direct,
                "all" => ReposListCollaboratorsAffiliation.All,
                _ => null,
            };
        }
    }
}