//HintName: G.JsonConverters.RoleBasedTask.g.cs
#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace G.JsonConverters
{
    /// <inheritdoc />
    public class RoleBasedTaskJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::G.RoleBasedTask>
    {
        /// <inheritdoc />
        public override global::G.RoleBasedTask Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options)); 

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
            if (__jsonProps.Contains("agreement")) __score0++;
            if (__jsonProps.Contains("agreement_selected")) __score0++;
            if (__jsonProps.Contains("allow_skip")) __score0++;
            if (__jsonProps.Contains("annotation_time")) __score0++;
            if (__jsonProps.Contains("annotations")) __score0++;
            if (__jsonProps.Contains("annotations_ids")) __score0++;
            if (__jsonProps.Contains("annotations_results")) __score0++;
            if (__jsonProps.Contains("annotators")) __score0++;
            if (__jsonProps.Contains("annotators_count")) __score0++;
            if (__jsonProps.Contains("avg_lead_time")) __score0++;
            if (__jsonProps.Contains("cancelled_annotations")) __score0++;
            if (__jsonProps.Contains("comment_authors")) __score0++;
            if (__jsonProps.Contains("comment_authors_count")) __score0++;
            if (__jsonProps.Contains("comment_count")) __score0++;
            if (__jsonProps.Contains("comments")) __score0++;
            if (__jsonProps.Contains("completed_at")) __score0++;
            if (__jsonProps.Contains("created_at")) __score0++;
            if (__jsonProps.Contains("data")) __score0++;
            if (__jsonProps.Contains("draft_exists")) __score0++;
            if (__jsonProps.Contains("drafts")) __score0++;
            if (__jsonProps.Contains("file_upload")) __score0++;
            if (__jsonProps.Contains("ground_truth")) __score0++;
            if (__jsonProps.Contains("id")) __score0++;
            if (__jsonProps.Contains("inner_id")) __score0++;
            if (__jsonProps.Contains("is_labeled")) __score0++;
            if (__jsonProps.Contains("last_comment_updated_at")) __score0++;
            if (__jsonProps.Contains("meta")) __score0++;
            if (__jsonProps.Contains("overlap")) __score0++;
            if (__jsonProps.Contains("precomputed_agreement")) __score0++;
            if (__jsonProps.Contains("predictions")) __score0++;
            if (__jsonProps.Contains("predictions_model_versions")) __score0++;
            if (__jsonProps.Contains("predictions_results")) __score0++;
            if (__jsonProps.Contains("predictions_score")) __score0++;
            if (__jsonProps.Contains("project")) __score0++;
            if (__jsonProps.Contains("review_time")) __score0++;
            if (__jsonProps.Contains("reviewed")) __score0++;
            if (__jsonProps.Contains("reviewers")) __score0++;
            if (__jsonProps.Contains("reviewers_count")) __score0++;
            if (__jsonProps.Contains("reviews_accepted")) __score0++;
            if (__jsonProps.Contains("reviews_rejected")) __score0++;
            if (__jsonProps.Contains("state")) __score0++;
            if (__jsonProps.Contains("storage_filename")) __score0++;
            if (__jsonProps.Contains("total_annotations")) __score0++;
            if (__jsonProps.Contains("total_predictions")) __score0++;
            if (__jsonProps.Contains("unresolved_comment_count")) __score0++;
            if (__jsonProps.Contains("updated_at")) __score0++;
            if (__jsonProps.Contains("updated_by")) __score0++;
            var __score1 = 0;
            if (__jsonProps.Contains("agreement")) __score1++;
            if (__jsonProps.Contains("agreement_selected")) __score1++;
            if (__jsonProps.Contains("allow_skip")) __score1++;
            if (__jsonProps.Contains("annotation_time")) __score1++;
            if (__jsonProps.Contains("annotations")) __score1++;
            if (__jsonProps.Contains("annotations_ids")) __score1++;
            if (__jsonProps.Contains("annotations_results")) __score1++;
            if (__jsonProps.Contains("annotators")) __score1++;
            if (__jsonProps.Contains("annotators_count")) __score1++;
            if (__jsonProps.Contains("avg_lead_time")) __score1++;
            if (__jsonProps.Contains("cancelled_annotations")) __score1++;
            if (__jsonProps.Contains("comment_authors")) __score1++;
            if (__jsonProps.Contains("comment_authors_count")) __score1++;
            if (__jsonProps.Contains("comment_count")) __score1++;
            if (__jsonProps.Contains("comments")) __score1++;
            if (__jsonProps.Contains("completed_at")) __score1++;
            if (__jsonProps.Contains("created_at")) __score1++;
            if (__jsonProps.Contains("data")) __score1++;
            if (__jsonProps.Contains("draft_exists")) __score1++;
            if (__jsonProps.Contains("drafts")) __score1++;
            if (__jsonProps.Contains("file_upload")) __score1++;
            if (__jsonProps.Contains("ground_truth")) __score1++;
            if (__jsonProps.Contains("id")) __score1++;
            if (__jsonProps.Contains("inner_id")) __score1++;
            if (__jsonProps.Contains("is_labeled")) __score1++;
            if (__jsonProps.Contains("last_comment_updated_at")) __score1++;
            if (__jsonProps.Contains("meta")) __score1++;
            if (__jsonProps.Contains("overlap")) __score1++;
            if (__jsonProps.Contains("precomputed_agreement")) __score1++;
            if (__jsonProps.Contains("predictions")) __score1++;
            if (__jsonProps.Contains("predictions_model_versions")) __score1++;
            if (__jsonProps.Contains("predictions_results")) __score1++;
            if (__jsonProps.Contains("predictions_score")) __score1++;
            if (__jsonProps.Contains("project")) __score1++;
            if (__jsonProps.Contains("review_time")) __score1++;
            if (__jsonProps.Contains("reviewed")) __score1++;
            if (__jsonProps.Contains("reviewers")) __score1++;
            if (__jsonProps.Contains("reviewers_count")) __score1++;
            if (__jsonProps.Contains("reviews_accepted")) __score1++;
            if (__jsonProps.Contains("reviews_rejected")) __score1++;
            if (__jsonProps.Contains("state")) __score1++;
            if (__jsonProps.Contains("storage_filename")) __score1++;
            if (__jsonProps.Contains("total_annotations")) __score1++;
            if (__jsonProps.Contains("total_predictions")) __score1++;
            if (__jsonProps.Contains("unresolved_comment_count")) __score1++;
            if (__jsonProps.Contains("updated_at")) __score1++;
            if (__jsonProps.Contains("updated_by")) __score1++;
            var __score2 = 0;
            if (__jsonProps.Contains("annotations")) __score2++;
            if (__jsonProps.Contains("annotations_results")) __score2++;
            if (__jsonProps.Contains("cancelled_annotations")) __score2++;
            if (__jsonProps.Contains("comment_count")) __score2++;
            if (__jsonProps.Contains("comments")) __score2++;
            if (__jsonProps.Contains("created_at")) __score2++;
            if (__jsonProps.Contains("data")) __score2++;
            if (__jsonProps.Contains("draft_exists")) __score2++;
            if (__jsonProps.Contains("drafts")) __score2++;
            if (__jsonProps.Contains("id")) __score2++;
            if (__jsonProps.Contains("predictions")) __score2++;
            if (__jsonProps.Contains("predictions_results")) __score2++;
            if (__jsonProps.Contains("predictions_score")) __score2++;
            if (__jsonProps.Contains("reviews_rejected")) __score2++;
            if (__jsonProps.Contains("state")) __score2++;
            if (__jsonProps.Contains("total_annotations")) __score2++;
            if (__jsonProps.Contains("total_predictions")) __score2++;
            if (__jsonProps.Contains("unresolved_comment_count")) __score2++;
            var __bestScore = 0;
            var __bestIndex = -1;
            if (__score0 > __bestScore) { __bestScore = __score0; __bestIndex = 0; }
            if (__score1 > __bestScore) { __bestScore = __score1; __bestIndex = 1; }
            if (__score2 > __bestScore) { __bestScore = __score2; __bestIndex = 2; }

            global::G.LseTask? lse = default;
            global::G.LseTaskSerializerForReviewers? lseSerializerForReviewers = default;
            global::G.LseTaskSerializerForAnnotators? lseSerializerForAnnotators = default;
            if (__bestIndex >= 0)
            {
                if (__bestIndex == 0)
                {
                    try
                    {
                        lse = global::System.Text.Json.JsonSerializer.Deserialize<global::G.LseTask>(__rawJson, options);
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
                        lseSerializerForReviewers = global::System.Text.Json.JsonSerializer.Deserialize<global::G.LseTaskSerializerForReviewers>(__rawJson, options);
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
                        lseSerializerForAnnotators = global::System.Text.Json.JsonSerializer.Deserialize<global::G.LseTaskSerializerForAnnotators>(__rawJson, options);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
            }

            if (lse == null && lseSerializerForReviewers == null && lseSerializerForAnnotators == null)
            {
                try
                {
                    lse = global::System.Text.Json.JsonSerializer.Deserialize<global::G.LseTask>(__rawJson, options);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    lseSerializerForReviewers = global::System.Text.Json.JsonSerializer.Deserialize<global::G.LseTaskSerializerForReviewers>(__rawJson, options);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    lseSerializerForAnnotators = global::System.Text.Json.JsonSerializer.Deserialize<global::G.LseTaskSerializerForAnnotators>(__rawJson, options);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            var __value = new global::G.RoleBasedTask(
                lse,

                lseSerializerForReviewers,

                lseSerializerForAnnotators
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::G.RoleBasedTask value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options)); 

            if (value.IsLse)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Lse, typeof(global::G.LseTask), options);
            }
            else if (value.IsLseSerializerForReviewers)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.LseSerializerForReviewers, typeof(global::G.LseTaskSerializerForReviewers), options);
            }
            else if (value.IsLseSerializerForAnnotators)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.LseSerializerForAnnotators, typeof(global::G.LseTaskSerializerForAnnotators), options);
            }
        }
    }
}