//HintName: G.Models.ViewType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Type of object that the view corresponds to.
    /// </summary>
    public enum ViewType
    {
        /// <summary>
        /// 
        /// </summary>
        Classifiers,
        /// <summary>
        /// 
        /// </summary>
        Dataset,
        /// <summary>
        /// 
        /// </summary>
        Datasets,
        /// <summary>
        /// 
        /// </summary>
        Experiment,
        /// <summary>
        /// 
        /// </summary>
        Experiments,
        /// <summary>
        /// 
        /// </summary>
        ForReviewDatasets,
        /// <summary>
        /// 
        /// </summary>
        ForReviewExperiments,
        /// <summary>
        /// 
        /// </summary>
        ForReviewProjectLog,
        /// <summary>
        /// 
        /// </summary>
        Logs,
        /// <summary>
        /// 
        /// </summary>
        Monitor,
        /// <summary>
        /// 
        /// </summary>
        Parameters,
        /// <summary>
        /// 
        /// </summary>
        Playground,
        /// <summary>
        /// 
        /// </summary>
        Playgrounds,
        /// <summary>
        /// 
        /// </summary>
        Projects,
        /// <summary>
        /// 
        /// </summary>
        Prompts,
        /// <summary>
        /// 
        /// </summary>
        Scorers,
        /// <summary>
        /// 
        /// </summary>
        Tools,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ViewTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ViewType value)
        {
            return value switch
            {
                ViewType.Classifiers => "classifiers",
                ViewType.Dataset => "dataset",
                ViewType.Datasets => "datasets",
                ViewType.Experiment => "experiment",
                ViewType.Experiments => "experiments",
                ViewType.ForReviewDatasets => "for_review_datasets",
                ViewType.ForReviewExperiments => "for_review_experiments",
                ViewType.ForReviewProjectLog => "for_review_project_log",
                ViewType.Logs => "logs",
                ViewType.Monitor => "monitor",
                ViewType.Parameters => "parameters",
                ViewType.Playground => "playground",
                ViewType.Playgrounds => "playgrounds",
                ViewType.Projects => "projects",
                ViewType.Prompts => "prompts",
                ViewType.Scorers => "scorers",
                ViewType.Tools => "tools",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ViewType? ToEnum(string value)
        {
            return value switch
            {
                "classifiers" => ViewType.Classifiers,
                "dataset" => ViewType.Dataset,
                "datasets" => ViewType.Datasets,
                "experiment" => ViewType.Experiment,
                "experiments" => ViewType.Experiments,
                "for_review_datasets" => ViewType.ForReviewDatasets,
                "for_review_experiments" => ViewType.ForReviewExperiments,
                "for_review_project_log" => ViewType.ForReviewProjectLog,
                "logs" => ViewType.Logs,
                "monitor" => ViewType.Monitor,
                "parameters" => ViewType.Parameters,
                "playground" => ViewType.Playground,
                "playgrounds" => ViewType.Playgrounds,
                "projects" => ViewType.Projects,
                "prompts" => ViewType.Prompts,
                "scorers" => ViewType.Scorers,
                "tools" => ViewType.Tools,
                _ => null,
            };
        }
    }
}