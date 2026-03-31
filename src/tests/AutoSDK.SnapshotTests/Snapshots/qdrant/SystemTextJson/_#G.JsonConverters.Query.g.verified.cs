//HintName: G.JsonConverters.Query.g.cs
#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace G.JsonConverters
{
    /// <inheritdoc />
    public class QueryJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::G.Query>
    {
        /// <inheritdoc />
        public override global::G.Query Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            using var __jsonDocument = global::System.Text.Json.JsonDocument.ParseValue(ref reader);
            var __rawJson = __jsonDocument.RootElement.GetRawText();
            var __jsonProps = new global::System.Collections.Generic.HashSet<string>();
            if (__jsonDocument.RootElement.ValueKind == global::System.Text.Json.JsonValueKind.Object)
            {
                foreach (var __jsonProp in __jsonDocument.RootElement.EnumerateObject())
                {
                    __jsonProps.Add(__jsonProp.Name);
                }
            }

            var __score0 = 0;
            if (__jsonProps.Contains("mmr")) __score0++;
            if (__jsonProps.Contains("nearest")) __score0++;
            var __score1 = 0;
            if (__jsonProps.Contains("recommend")) __score1++;
            var __score2 = 0;
            if (__jsonProps.Contains("discover")) __score2++;
            var __score3 = 0;
            if (__jsonProps.Contains("context")) __score3++;
            var __score4 = 0;
            if (__jsonProps.Contains("order_by")) __score4++;
            var __score5 = 0;
            if (__jsonProps.Contains("fusion")) __score5++;
            var __score6 = 0;
            if (__jsonProps.Contains("rrf")) __score6++;
            var __score7 = 0;
            if (__jsonProps.Contains("defaults")) __score7++;
            if (__jsonProps.Contains("formula")) __score7++;
            var __score8 = 0;
            if (__jsonProps.Contains("sample")) __score8++;
            var __score9 = 0;
            if (__jsonProps.Contains("relevance_feedback")) __score9++;
            var __bestScore = 0;
            var __bestIndex = -1;
            if (__score0 > __bestScore) { __bestScore = __score0; __bestIndex = 0; }
            if (__score1 > __bestScore) { __bestScore = __score1; __bestIndex = 1; }
            if (__score2 > __bestScore) { __bestScore = __score2; __bestIndex = 2; }
            if (__score3 > __bestScore) { __bestScore = __score3; __bestIndex = 3; }
            if (__score4 > __bestScore) { __bestScore = __score4; __bestIndex = 4; }
            if (__score5 > __bestScore) { __bestScore = __score5; __bestIndex = 5; }
            if (__score6 > __bestScore) { __bestScore = __score6; __bestIndex = 6; }
            if (__score7 > __bestScore) { __bestScore = __score7; __bestIndex = 7; }
            if (__score8 > __bestScore) { __bestScore = __score8; __bestIndex = 8; }
            if (__score9 > __bestScore) { __bestScore = __score9; __bestIndex = 9; }

            global::G.NearestQuery? nearest = default;
            global::G.RecommendQuery? recommend = default;
            global::G.DiscoverQuery? discover = default;
            global::G.ContextQuery? context = default;
            global::G.OrderByQuery? orderBy = default;
            global::G.FusionQuery? fusion = default;
            global::G.RrfQuery? rrf = default;
            global::G.FormulaQuery? formula = default;
            global::G.SampleQuery? sample = default;
            global::G.RelevanceFeedbackQuery? relevanceFeedback = default;
            if (__bestIndex >= 0)
            {
                if (__bestIndex == 0)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.NearestQuery), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.NearestQuery> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.NearestQuery).Name}");
                        nearest = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
                else if (__bestIndex == 1)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.RecommendQuery), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.RecommendQuery> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.RecommendQuery).Name}");
                        recommend = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
                else if (__bestIndex == 2)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.DiscoverQuery), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.DiscoverQuery> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.DiscoverQuery).Name}");
                        discover = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
                else if (__bestIndex == 3)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ContextQuery), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ContextQuery> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.ContextQuery).Name}");
                        context = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
                else if (__bestIndex == 4)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.OrderByQuery), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.OrderByQuery> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.OrderByQuery).Name}");
                        orderBy = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
                else if (__bestIndex == 5)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.FusionQuery), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.FusionQuery> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.FusionQuery).Name}");
                        fusion = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
                else if (__bestIndex == 6)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.RrfQuery), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.RrfQuery> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.RrfQuery).Name}");
                        rrf = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
                else if (__bestIndex == 7)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.FormulaQuery), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.FormulaQuery> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.FormulaQuery).Name}");
                        formula = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
                else if (__bestIndex == 8)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.SampleQuery), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.SampleQuery> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.SampleQuery).Name}");
                        sample = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
                else if (__bestIndex == 9)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.RelevanceFeedbackQuery), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.RelevanceFeedbackQuery> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.RelevanceFeedbackQuery).Name}");
                        relevanceFeedback = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
            }

            if (nearest == null && recommend == null && discover == null && context == null && orderBy == null && fusion == null && rrf == null && formula == null && sample == null && relevanceFeedback == null)
            {
                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.NearestQuery), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.NearestQuery> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.NearestQuery).Name}");
                    nearest = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.RecommendQuery), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.RecommendQuery> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.RecommendQuery).Name}");
                    recommend = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.DiscoverQuery), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.DiscoverQuery> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.DiscoverQuery).Name}");
                    discover = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ContextQuery), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ContextQuery> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.ContextQuery).Name}");
                    context = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.OrderByQuery), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.OrderByQuery> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.OrderByQuery).Name}");
                    orderBy = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.FusionQuery), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.FusionQuery> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.FusionQuery).Name}");
                    fusion = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.RrfQuery), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.RrfQuery> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.RrfQuery).Name}");
                    rrf = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.FormulaQuery), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.FormulaQuery> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.FormulaQuery).Name}");
                    formula = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.SampleQuery), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.SampleQuery> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.SampleQuery).Name}");
                    sample = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.RelevanceFeedbackQuery), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.RelevanceFeedbackQuery> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.RelevanceFeedbackQuery).Name}");
                    relevanceFeedback = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            var __value = new global::G.Query(
                nearest,

                recommend,

                discover,

                context,

                orderBy,

                fusion,

                rrf,

                formula,

                sample,

                relevanceFeedback
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::G.Query value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsNearest)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.NearestQuery), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.NearestQuery?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.NearestQuery).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Nearest!, typeInfo);
            }
            else if (value.IsRecommend)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.RecommendQuery), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.RecommendQuery?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.RecommendQuery).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Recommend!, typeInfo);
            }
            else if (value.IsDiscover)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.DiscoverQuery), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.DiscoverQuery?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.DiscoverQuery).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Discover!, typeInfo);
            }
            else if (value.IsContext)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ContextQuery), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ContextQuery?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.ContextQuery).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Context!, typeInfo);
            }
            else if (value.IsOrderBy)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.OrderByQuery), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.OrderByQuery?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.OrderByQuery).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.OrderBy!, typeInfo);
            }
            else if (value.IsFusion)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.FusionQuery), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.FusionQuery?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.FusionQuery).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Fusion!, typeInfo);
            }
            else if (value.IsRrf)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.RrfQuery), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.RrfQuery?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.RrfQuery).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Rrf!, typeInfo);
            }
            else if (value.IsFormula)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.FormulaQuery), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.FormulaQuery?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.FormulaQuery).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Formula!, typeInfo);
            }
            else if (value.IsSample)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.SampleQuery), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.SampleQuery?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.SampleQuery).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Sample!, typeInfo);
            }
            else if (value.IsRelevanceFeedback)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.RelevanceFeedbackQuery), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.RelevanceFeedbackQuery?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.RelevanceFeedbackQuery).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.RelevanceFeedback!, typeInfo);
            }
        }
    }
}