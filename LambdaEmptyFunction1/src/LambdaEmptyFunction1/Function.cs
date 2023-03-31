using Amazon.Lambda.Core;
using Amazon.Lambda.APIGatewayEvents;

// Assembly attribute to enable the Lambda function's JSON input to be converted into a .NET class.
[assembly: LambdaSerializer(typeof(Amazon.Lambda.Serialization.SystemTextJson.DefaultLambdaJsonSerializer))]

namespace LambdaEmptyFunction1
{
    public class Function
    {
        public APIGatewayProxyResponse Handler(APIGatewayProxyRequest apigProxyEvent)
        {


            return new APIGatewayProxyResponse
            {
                Body = apigProxyEvent.Body,
                StatusCode = 200,
            };
        }
    }
}
