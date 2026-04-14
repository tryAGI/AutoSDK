using AutoSDK.Serialization.Json;
using AutoSDK.SourceGenerators;
using Microsoft.CodeAnalysis;

namespace AutoSDK.SnapshotTests;

public partial class Tests
{
    [TestMethod]
    [DataRow(JsonSerializerType.NewtonsoftJson)]
    [DataRow(JsonSerializerType.SystemTextJson)]
    public Task PaginationSdkGenerator(JsonSerializerType jsonSerializerType)
    {
        const string spec = """
openapi: 3.0.3
info:
  title: Pagination
  version: 1.0.0
paths:
  /widgets:
    get:
      operationId: listWidgets
      parameters:
        - in: query
          name: cursor
          schema:
            type: string
        - in: query
          name: limit
          schema:
            type: integer
      x-speakeasy-pagination:
        type: cursor
        inputs:
          - name: cursor
            in: query
            type: cursor
          - name: limit
            in: query
            type: limit
        outputs:
          results: $.data
          nextCursor: $.next_cursor
      responses:
        '200':
          description: OK
          content:
            application/json:
              schema:
                type: object
                properties:
                  data:
                    type: array
                    items:
                      type: object
                      properties:
                        id:
                          type: string
                  next_cursor:
                    type: string
  /records:
    get:
      operationId: listRecords
      responses:
        '200':
          description: OK
          content:
            application/json:
              schema:
                type: object
                properties:
                  data:
                    type: array
                    x-stainless-pagination-property:
                      purpose: items
                    items:
                      type: object
                      properties:
                        id:
                          type: string
                  next_url:
                    type: string
                    format: uri
                    x-stainless-pagination-property:
                      purpose: cursor_url_field
""";

        return CheckSourceAsync<SdkGenerator>(
            jsonSerializerType: jsonSerializerType,
            additionalTexts:
            [
                new CustomAdditionalText(
                    path: "pagination.yaml",
                    text: spec)
            ],
            callerName: nameof(PaginationSdkGenerator),
            additionalGenerators: [new CliGenerator()]);
    }
}
