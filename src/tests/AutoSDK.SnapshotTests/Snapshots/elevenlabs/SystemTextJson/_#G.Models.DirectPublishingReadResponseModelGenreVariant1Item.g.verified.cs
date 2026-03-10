//HintName: G.Models.DirectPublishingReadResponseModelGenreVariant1Item.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum DirectPublishingReadResponseModelGenreVariant1Item
    {
        /// <summary>
        /// 
        /// </summary>
        Fantasy,
        /// <summary>
        /// 
        /// </summary>
        Romance,
        /// <summary>
        /// 
        /// </summary>
        ScienceFiction,
        /// <summary>
        /// 
        /// </summary>
        MysteryAndThriller,
        /// <summary>
        /// 
        /// </summary>
        ActionAndAdventure,
        /// <summary>
        /// 
        /// </summary>
        Dystopia,
        /// <summary>
        /// 
        /// </summary>
        BusinessAndEconomics,
        /// <summary>
        /// 
        /// </summary>
        Technology,
        /// <summary>
        /// 
        /// </summary>
        DetectiveAndCrime,
        /// <summary>
        /// 
        /// </summary>
        Horror,
        /// <summary>
        /// 
        /// </summary>
        BiographyAndMemoir,
        /// <summary>
        /// 
        /// </summary>
        EducationAndLearning,
        /// <summary>
        /// 
        /// </summary>
        History,
        /// <summary>
        /// 
        /// </summary>
        ChildrensLiterature,
        /// <summary>
        /// 
        /// </summary>
        FairyTalesAndFolklore,
        /// <summary>
        /// 
        /// </summary>
        FanFiction,
        /// <summary>
        /// 
        /// </summary>
        GeneralFiction,
        /// <summary>
        /// 
        /// </summary>
        HealthAndWellness,
        /// <summary>
        /// 
        /// </summary>
        HistoricalFiction,
        /// <summary>
        /// 
        /// </summary>
        Humor,
        /// <summary>
        /// 
        /// </summary>
        LiteraryClassics,
        /// <summary>
        /// 
        /// </summary>
        Philosophy,
        /// <summary>
        /// 
        /// </summary>
        Poetry,
        /// <summary>
        /// 
        /// </summary>
        PoliticsAndGovernment,
        /// <summary>
        /// 
        /// </summary>
        Psychology,
        /// <summary>
        /// 
        /// </summary>
        ScienceAndNature,
        /// <summary>
        /// 
        /// </summary>
        SelfHelp,
        /// <summary>
        /// 
        /// </summary>
        SpiritualityAndReligion,
        /// <summary>
        /// 
        /// </summary>
        Travel,
        /// <summary>
        /// 
        /// </summary>
        TrueCrime,
        /// <summary>
        /// 
        /// </summary>
        Other,
        /// <summary>
        /// 
        /// </summary>
        AdultRomance,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class DirectPublishingReadResponseModelGenreVariant1ItemExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this DirectPublishingReadResponseModelGenreVariant1Item value)
        {
            return value switch
            {
                DirectPublishingReadResponseModelGenreVariant1Item.Fantasy => "Fantasy",
                DirectPublishingReadResponseModelGenreVariant1Item.Romance => "Romance",
                DirectPublishingReadResponseModelGenreVariant1Item.ScienceFiction => "Science Fiction",
                DirectPublishingReadResponseModelGenreVariant1Item.MysteryAndThriller => "Mystery and Thriller",
                DirectPublishingReadResponseModelGenreVariant1Item.ActionAndAdventure => "Action and Adventure",
                DirectPublishingReadResponseModelGenreVariant1Item.Dystopia => "Dystopia",
                DirectPublishingReadResponseModelGenreVariant1Item.BusinessAndEconomics => "Business and Economics",
                DirectPublishingReadResponseModelGenreVariant1Item.Technology => "Technology",
                DirectPublishingReadResponseModelGenreVariant1Item.DetectiveAndCrime => "Detective and Crime",
                DirectPublishingReadResponseModelGenreVariant1Item.Horror => "Horror",
                DirectPublishingReadResponseModelGenreVariant1Item.BiographyAndMemoir => "Biography and Memoir",
                DirectPublishingReadResponseModelGenreVariant1Item.EducationAndLearning => "Education and Learning",
                DirectPublishingReadResponseModelGenreVariant1Item.History => "History",
                DirectPublishingReadResponseModelGenreVariant1Item.ChildrensLiterature => "Children's Literature",
                DirectPublishingReadResponseModelGenreVariant1Item.FairyTalesAndFolklore => "Fairy Tales and Folklore",
                DirectPublishingReadResponseModelGenreVariant1Item.FanFiction => "Fan Fiction",
                DirectPublishingReadResponseModelGenreVariant1Item.GeneralFiction => "General Fiction",
                DirectPublishingReadResponseModelGenreVariant1Item.HealthAndWellness => "Health and Wellness",
                DirectPublishingReadResponseModelGenreVariant1Item.HistoricalFiction => "Historical Fiction",
                DirectPublishingReadResponseModelGenreVariant1Item.Humor => "Humor",
                DirectPublishingReadResponseModelGenreVariant1Item.LiteraryClassics => "Literary Classics",
                DirectPublishingReadResponseModelGenreVariant1Item.Philosophy => "Philosophy",
                DirectPublishingReadResponseModelGenreVariant1Item.Poetry => "Poetry",
                DirectPublishingReadResponseModelGenreVariant1Item.PoliticsAndGovernment => "Politics and Government",
                DirectPublishingReadResponseModelGenreVariant1Item.Psychology => "Psychology",
                DirectPublishingReadResponseModelGenreVariant1Item.ScienceAndNature => "Science and Nature",
                DirectPublishingReadResponseModelGenreVariant1Item.SelfHelp => "Self-Help",
                DirectPublishingReadResponseModelGenreVariant1Item.SpiritualityAndReligion => "Spirituality and Religion",
                DirectPublishingReadResponseModelGenreVariant1Item.Travel => "Travel",
                DirectPublishingReadResponseModelGenreVariant1Item.TrueCrime => "True Crime",
                DirectPublishingReadResponseModelGenreVariant1Item.Other => "Other",
                DirectPublishingReadResponseModelGenreVariant1Item.AdultRomance => "Adult Romance",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static DirectPublishingReadResponseModelGenreVariant1Item? ToEnum(string value)
        {
            return value switch
            {
                "Fantasy" => DirectPublishingReadResponseModelGenreVariant1Item.Fantasy,
                "Romance" => DirectPublishingReadResponseModelGenreVariant1Item.Romance,
                "Science Fiction" => DirectPublishingReadResponseModelGenreVariant1Item.ScienceFiction,
                "Mystery and Thriller" => DirectPublishingReadResponseModelGenreVariant1Item.MysteryAndThriller,
                "Action and Adventure" => DirectPublishingReadResponseModelGenreVariant1Item.ActionAndAdventure,
                "Dystopia" => DirectPublishingReadResponseModelGenreVariant1Item.Dystopia,
                "Business and Economics" => DirectPublishingReadResponseModelGenreVariant1Item.BusinessAndEconomics,
                "Technology" => DirectPublishingReadResponseModelGenreVariant1Item.Technology,
                "Detective and Crime" => DirectPublishingReadResponseModelGenreVariant1Item.DetectiveAndCrime,
                "Horror" => DirectPublishingReadResponseModelGenreVariant1Item.Horror,
                "Biography and Memoir" => DirectPublishingReadResponseModelGenreVariant1Item.BiographyAndMemoir,
                "Education and Learning" => DirectPublishingReadResponseModelGenreVariant1Item.EducationAndLearning,
                "History" => DirectPublishingReadResponseModelGenreVariant1Item.History,
                "Children's Literature" => DirectPublishingReadResponseModelGenreVariant1Item.ChildrensLiterature,
                "Fairy Tales and Folklore" => DirectPublishingReadResponseModelGenreVariant1Item.FairyTalesAndFolklore,
                "Fan Fiction" => DirectPublishingReadResponseModelGenreVariant1Item.FanFiction,
                "General Fiction" => DirectPublishingReadResponseModelGenreVariant1Item.GeneralFiction,
                "Health and Wellness" => DirectPublishingReadResponseModelGenreVariant1Item.HealthAndWellness,
                "Historical Fiction" => DirectPublishingReadResponseModelGenreVariant1Item.HistoricalFiction,
                "Humor" => DirectPublishingReadResponseModelGenreVariant1Item.Humor,
                "Literary Classics" => DirectPublishingReadResponseModelGenreVariant1Item.LiteraryClassics,
                "Philosophy" => DirectPublishingReadResponseModelGenreVariant1Item.Philosophy,
                "Poetry" => DirectPublishingReadResponseModelGenreVariant1Item.Poetry,
                "Politics and Government" => DirectPublishingReadResponseModelGenreVariant1Item.PoliticsAndGovernment,
                "Psychology" => DirectPublishingReadResponseModelGenreVariant1Item.Psychology,
                "Science and Nature" => DirectPublishingReadResponseModelGenreVariant1Item.ScienceAndNature,
                "Self-Help" => DirectPublishingReadResponseModelGenreVariant1Item.SelfHelp,
                "Spirituality and Religion" => DirectPublishingReadResponseModelGenreVariant1Item.SpiritualityAndReligion,
                "Travel" => DirectPublishingReadResponseModelGenreVariant1Item.Travel,
                "True Crime" => DirectPublishingReadResponseModelGenreVariant1Item.TrueCrime,
                "Other" => DirectPublishingReadResponseModelGenreVariant1Item.Other,
                "Adult Romance" => DirectPublishingReadResponseModelGenreVariant1Item.AdultRomance,
                _ => null,
            };
        }
    }
}