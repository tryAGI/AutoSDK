//HintName: G.Models.ViewViewType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Type of object that the view corresponds to.
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum ViewViewType
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="classifiers")]
        Classifiers,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="dataset")]
        Dataset,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="datasets")]
        Datasets,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="experiment")]
        Experiment,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="experiments")]
        Experiments,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="for_review_datasets")]
        ForReviewDatasets,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="for_review_experiments")]
        ForReviewExperiments,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="for_review_project_log")]
        ForReviewProjectLog,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="logs")]
        Logs,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="monitor")]
        Monitor,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="parameters")]
        Parameters,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="playground")]
        Playground,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="playgrounds")]
        Playgrounds,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="projects")]
        Projects,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="prompts")]
        Prompts,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="scorers")]
        Scorers,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="tools")]
        Tools,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ViewViewTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ViewViewType value)
        {
            return value switch
            {
                ViewViewType.Classifiers => "classifiers",
                ViewViewType.Dataset => "dataset",
                ViewViewType.Datasets => "datasets",
                ViewViewType.Experiment => "experiment",
                ViewViewType.Experiments => "experiments",
                ViewViewType.ForReviewDatasets => "for_review_datasets",
                ViewViewType.ForReviewExperiments => "for_review_experiments",
                ViewViewType.ForReviewProjectLog => "for_review_project_log",
                ViewViewType.Logs => "logs",
                ViewViewType.Monitor => "monitor",
                ViewViewType.Parameters => "parameters",
                ViewViewType.Playground => "playground",
                ViewViewType.Playgrounds => "playgrounds",
                ViewViewType.Projects => "projects",
                ViewViewType.Prompts => "prompts",
                ViewViewType.Scorers => "scorers",
                ViewViewType.Tools => "tools",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ViewViewType? ToEnum(string value)
        {
            return value switch
            {
                "classifiers" => ViewViewType.Classifiers,
                "dataset" => ViewViewType.Dataset,
                "datasets" => ViewViewType.Datasets,
                "experiment" => ViewViewType.Experiment,
                "experiments" => ViewViewType.Experiments,
                "for_review_datasets" => ViewViewType.ForReviewDatasets,
                "for_review_experiments" => ViewViewType.ForReviewExperiments,
                "for_review_project_log" => ViewViewType.ForReviewProjectLog,
                "logs" => ViewViewType.Logs,
                "monitor" => ViewViewType.Monitor,
                "parameters" => ViewViewType.Parameters,
                "playground" => ViewViewType.Playground,
                "playgrounds" => ViewViewType.Playgrounds,
                "projects" => ViewViewType.Projects,
                "prompts" => ViewViewType.Prompts,
                "scorers" => ViewViewType.Scorers,
                "tools" => ViewViewType.Tools,
                _ => null,
            };
        }
    }
}