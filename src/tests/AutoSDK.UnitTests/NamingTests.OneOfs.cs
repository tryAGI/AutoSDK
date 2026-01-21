namespace AutoSDK.UnitTests;

public partial class NamingTests
{
    [TestMethod]
    public void OneOfs()
    {
        var models = PrepareModels(@"openapi: 3.0.1
info:
  title: Fake
  version: 1.0.0
paths:
  /fake:
    get:
      operationId: fake
      responses:
        '200':
            description: OK
components:
    schemas:
        CreateAssistantRequest:
            required:
                - model
            type: object
            properties:
                model:
                    anyOf:
                        - type: string
                        - enum:
                              - gpt-4o
                              - gpt-4o-2024-08-06
                              - gpt-4o-2024-05-13
                              - gpt-4o-mini
                              - gpt-4o-mini-2024-07-18
                              - gpt-4-turbo
                              - gpt-4-turbo-2024-04-09
                              - gpt-4-0125-preview
                              - gpt-4-turbo-preview
                              - gpt-4-1106-preview
                              - gpt-4-vision-preview
                              - gpt-4
                              - gpt-4-0314
                              - gpt-4-0613
                              - gpt-4-32k
                              - gpt-4-32k-0314
                              - gpt-4-32k-0613
                              - gpt-3.5-turbo
                              - gpt-3.5-turbo-16k
                              - gpt-3.5-turbo-0613
                              - gpt-3.5-turbo-1106
                              - gpt-3.5-turbo-0125
                              - gpt-3.5-turbo-16k-0613
                          type: string
                    description: ""ID of the model to use. You can use the [List models](/docs/api-reference/models/list) API to see all of your available models, or see our [Model overview](/docs/models/overview) for descriptions of them.\n""
                    example: gpt-4o
                    x-oaiTypeLabel: string
                tools:
                    maxItems: 128
                    type: array
                    items:
                        oneOf:
                            - $ref: '#/components/schemas/AssistantToolsCode'
                            - $ref: '#/components/schemas/AssistantToolsFileSearch'
                            - $ref: '#/components/schemas/AssistantToolsFunction'
                        x-oaiExpandable: true
                    description: ""A list of tool enabled on the assistant. There can be a maximum of 128 tools per assistant. Tools can be of types `code_interpreter`, `file_search`, or `function`.\n""
                tool_resources:
                    type: object
                    properties:
                        code_interpreter:
                            type: object
                            properties:
                                file_ids:
                                    maxItems: 20
                                    type: array
                                    items:
                                        type: string
                                    description: ""A list of [file](/docs/api-reference/files) IDs made available to the `code_interpreter` tool. There can be a maximum of 20 files associated with the tool.\n""
                        file_search:
                            type: object
                            oneOf:
                                - required:
                                      - vector_store_ids
                                - required:
                                      - vector_stores
                            properties:
                                vector_store_ids:
                                    maxItems: 1
                                    type: array
                                    items:
                                        type: string
                                    description: ""The [vector store](/docs/api-reference/vector-stores/object) attached to this assistant. There can be a maximum of 1 vector store attached to the assistant.\n""
                                vector_stores:
                                    maxItems: 1
                                    type: array
                                    items:
                                        type: object
                                        properties:
                                            file_ids:
                                                maxItems: 10000
                                                type: array
                                                items:
                                                    type: string
                                                description: ""A list of [file](/docs/api-reference/files) IDs to add to the vector store. There can be a maximum of 10000 files in a vector store.\n""
                                            chunking_strategy:
                                                type: object
                                                oneOf:
                                                    - title: Auto Chunking Strategy
                                                      required:
                                                          - type
                                                      type: object
                                                      properties:
                                                          type:
                                                              enum:
                                                                  - auto
                                                              type: string
                                                              description: Always `auto`.
                                                      additionalProperties: false
                                                      description: The default strategy. This strategy currently uses a `max_chunk_size_tokens` of `800` and `chunk_overlap_tokens` of `400`.
                                                    - title: Static Chunking Strategy
                                                      required:
                                                          - type
                                                          - static
                                                      type: object
                                                      properties:
                                                          type:
                                                              enum:
                                                                  - static
                                                              type: string
                                                              description: Always `static`.
                                                          static:
                                                              required:
                                                                  - max_chunk_size_tokens
                                                                  - chunk_overlap_tokens
                                                              type: object
                                                              properties:
                                                                  max_chunk_size_tokens:
                                                                      maximum: 4096
                                                                      minimum: 100
                                                                      type: integer
                                                                      description: The maximum number of tokens in each chunk. The default value is `800`. The minimum value is `100` and the maximum value is `4096`.
                                                                  chunk_overlap_tokens:
                                                                      type: integer
                                                                      description: ""The number of tokens that overlap between chunks. The default value is `400`.\n\nNote that the overlap must not exceed half of `max_chunk_size_tokens`.\n""
                                                              additionalProperties: false
                                                      additionalProperties: false
                                                description: 'The chunking strategy used to chunk the file(s). If not set, will use the `auto` strategy.'
                                                x-oaiExpandable: true
                                            metadata:
                                                type: object
                                                description: ""Set of 16 key-value pairs that can be attached to a vector store. This can be useful for storing additional information about the vector store in a structured format. Keys can be a maximum of 64 characters long and values can be a maxium of 512 characters long.\n""
                                                x-oaiTypeLabel: map
                                    description: ""A helper to create a [vector store](/docs/api-reference/vector-stores/object) with file_ids and attach it to this assistant. There can be a maximum of 1 vector store attached to the assistant.\n""
                    description: ""A set of resources that are used by the assistant's tools. The resources are specific to the type of tool. For example, the `code_interpreter` tool requires a list of file IDs, while the `file_search` tool requires a list of vector store IDs.\n""
                    nullable: true
                metadata:
                    type: object
                    description: ""Set of 16 key-value pairs that can be attached to an object. This can be useful for storing additional information about the object in a structured format. Keys can be a maximum of 64 characters long and values can be a maxium of 512 characters long.\n""
                    nullable: true
                    x-oaiTypeLabel: map
                temperature:
                    maximum: 2
                    minimum: 0
                    type: number
                    description: empty
                    default: 1
                    nullable: true
                    example: 1
                top_p:
                    maximum: 1
                    minimum: 0
                    type: number
                    description: empty
                    default: 1
                    nullable: true
                    example: 1
                response_format:
                    $ref: '#/components/schemas/AssistantsApiResponseFormatOption'
            additionalProperties: false

        AssistantsApiResponseFormatOption:
            oneOf:
                - enum:
                      - auto
                  type: string
                  description: ""`auto` is the default value\n""
                - $ref: '#/components/schemas/ResponseFormatText'
                - $ref: '#/components/schemas/ResponseFormatJsonObject'
                - $ref: '#/components/schemas/ResponseFormatJsonSchema'
            description: ""Specifies the format that the model must output. Compatible with [GPT-4o](/docs/models/gpt-4o), [GPT-4 Turbo](/docs/models/gpt-4-turbo-and-gpt-4), and all GPT-3.5 Turbo models since `gpt-3.5-turbo-1106`.\n\nSetting to `{{ \""type\"": \""json_schema\"", \""json_schema\"": {{...}} }}` enables Structured Outputs which guarantees the model will match your supplied JSON schema. Learn more in the [Structured Outputs guide](/docs/guides/structured-outputs).\n\nSetting to `{{ \""type\"": \""json_object\"" }}` enables JSON mode, which guarantees the message the model generates is valid JSON.\n\n**Important:** when using JSON mode, you **must** also instruct the model to produce JSON yourself via a system or user message. Without this, the model may generate an unending stream of whitespace until the generation reaches the token limit, resulting in a long-running and seemingly \""stuck\"" request. Also note that the message content may be partially cut off if `finish_reason=\""length\""`, which indicates the generation exceeded `max_tokens` or the conversation exceeded the max context length.\n""
            x-oaiExpandable: true
        ResponseFormatText:
            required:
                - type
            type: object
            properties:
                type:
                    enum:
                        - text
                    type: string
                    description: 'The type of response format being defined: `text`'
        ResponseFormatJsonObject:
            required:
                - type
            type: object
            properties:
                type:
                    enum:
                        - json_object
                    type: string
                    description: 'The type of response format being defined: `json_object`'
        ResponseFormatJsonSchemaSchema:
            type: object
            description: 'The schema for the response format, described as a JSON Schema object.'
        ResponseFormatJsonSchema:
            required:
                - type
                - json_schema
            type: object
            properties:
                type:
                    enum:
                        - json_schema
                    type: string
                    description: 'The type of response format being defined: `json_schema`'
                json_schema:
                    required:
                        - type
                        - name
                    type: object
                    properties:
                        description:
                            type: string
                            description: 'A description of what the response format is for, used by the model to determine how to respond in the format.'
                        name:
                            type: string
                            description: 'The name of the response format. Must be a-z, A-Z, 0-9, or contain underscores and dashes, with a maximum length of 64.'
                        schema:
                            $ref: '#/components/schemas/ResponseFormatJsonSchemaSchema'
                        strict:
                            type: boolean
                            description: 'Whether to enable strict schema adherence when generating the output. If set to true, the model will always follow the exact schema defined in the `schema` field. Only a subset of JSON Schema is supported when `strict` is `true`. To learn more, read the [Structured Outputs guide](/docs/guides/structured-outputs).'
                            default: false
                            nullable: true
        AssistantToolsCode:
            title: Code interpreter tool
            required:
                - type
            type: object
            properties:
                type:
                    enum:
                        - code_interpreter
                    type: string
                    description: 'The type of tool being defined: `code_interpreter`'
        AssistantToolsFileSearch:
            title: FileSearch tool
            required:
                - type
            type: object
            properties:
                type:
                    enum:
                        - file_search
                    type: string
                    description: 'The type of tool being defined: `file_search`'
                file_search:
                    type: object
                    properties:
                        max_num_results:
                            maximum: 50
                            minimum: 1
                            type: integer
                            description: ""The maximum number of results the file search tool should output. The default is 20 for `gpt-4*` models and 5 for `gpt-3.5-turbo`. This number should be between 1 and 50 inclusive.\n\nNote that the file search tool may output fewer than `max_num_results` results. See the [file search tool documentation](/docs/assistants/tools/file-search/number-of-chunks-returned) for more information.\n""
                    description: Overrides for the file search tool.
        AssistantToolsFunction:
            title: Function tool
            required:
                - type
                - function
            type: object
            properties:
                type:
                    enum:
                        - function
                    type: string
                    description: 'The type of tool being defined: `function`'
                function:
                    $ref: '#/components/schemas/FunctionObject'
        FunctionObject:
            required:
                - name
            type: object
            properties:
                description:
                    type: string
                    description: 'A description of what the function does, used by the model to choose when and how to call the function.'
                name:
                    type: string
                    description: 'The name of the function to be called. Must be a-z, A-Z, 0-9, or contain underscores and dashes, with a maximum length of 64.'
                parameters:
                    $ref: '#/components/schemas/FunctionParameters'
                strict:
                    type: boolean
                    description: 'Whether to enable strict schema adherence when generating the function call. If set to true, the model will follow the exact schema defined in the `parameters` field. Only a subset of JSON Schema is supported when `strict` is `true`. Learn more about Structured Outputs in the [function calling guide](docs/guides/function-calling).'
                    default: false
                    nullable: true
        FunctionParameters:
            type: object
            description: ""The parameters the functions accepts, described as a JSON Schema object. See the [guide](/docs/guides/function-calling) for examples, and the [JSON Schema reference](https://json-schema.org/understanding-json-schema/) for documentation about the format. \n\nOmitting `parameters` defines a function with an empty parameter list.""
");
        
        models.Select(x => x.ClassName).Should().BeEquivalentTo([
            "CreateAssistantRequest",
            "CreateAssistantRequestModel", // Optimized name
            "CreateAssistantRequestToolDiscriminator",
            // "CreateAssistantRequestToolDiscriminatorType", // No longer generated in Microsoft.OpenApi 3.x
            "CreateAssistantRequestToolResources",
            "CreateAssistantRequestToolResourcesCodeInterpreter",
            "CreateAssistantRequestToolResourcesFileSearch",
            "CreateAssistantRequestToolResourcesFileSearchVectorStore",
            "CreateAssistantRequestToolResourcesFileSearchVectorStoreChunkingStrategy",
            "CreateAssistantRequestToolResourcesFileSearchVectorStoreChunkingStrategyVariant1",
            "CreateAssistantRequestToolResourcesFileSearchVectorStoreChunkingStrategyVariant1Type",
            "CreateAssistantRequestToolResourcesFileSearchVectorStoreChunkingStrategyVariant2",
            "CreateAssistantRequestToolResourcesFileSearchVectorStoreChunkingStrategyVariant2Type",
            "CreateAssistantRequestToolResourcesFileSearchVectorStoreChunkingStrategyVariant2Static",
            "CreateAssistantRequestToolResourcesFileSearchVectorStoreChunkingStrategyDiscriminator",
            // "CreateAssistantRequestToolResourcesFileSearchVectorStoreChunkingStrategyDiscriminatorType", // No longer generated in Microsoft.OpenApi 3.x
            "CreateAssistantRequestToolResourcesFileSearchVectorStoreMetadata",
            "CreateAssistantRequestToolResourcesFileSearchVariant1",
            "CreateAssistantRequestToolResourcesFileSearchVariant2",
            "CreateAssistantRequestMetadata",
            "AssistantsApiResponseFormatOption",
            "AssistantsApiResponseFormatOptionEnum",
            "ResponseFormatText",
            "ResponseFormatTextType",
            "ResponseFormatJsonObject",
            "ResponseFormatJsonObjectType",
            "ResponseFormatJsonSchemaSchema",
            "ResponseFormatJsonSchema",
            "ResponseFormatJsonSchemaType",
            "ResponseFormatJsonSchemaJsonSchema",
            "AssistantToolsCode",
            "AssistantToolsCodeType",
            "AssistantToolsFileSearch",
            "AssistantToolsFileSearchType",
            "AssistantToolsFileSearchFileSearch",
            "AssistantToolsFunction",
            "AssistantToolsFunctionType",
            "FunctionObject",
            "FunctionParameters",
        ]);
    }
    
    [TestMethod]
    public void OneOfs_Named()
    {
        var models = PrepareModels(@"openapi: 3.0.1
info:
  title: Fake
  version: 1.0.0
paths:
  /fake:
    get:
      operationId: fake
      responses:
        '200':
            description: OK
components:
  schemas:
    PushModelStatus:
      description: Status pushing the model.
      anyOf:
        - type: string
        - type: string
          enum:
            - retrieving manifest
            - starting upload
            - pushing manifest
            - success
");
        
        models.Select(x => x.ClassName).Should().BeEquivalentTo([
            "PushModelStatus",
            "PushModelStatusEnum", // Optimized name
        ]);
    }
}