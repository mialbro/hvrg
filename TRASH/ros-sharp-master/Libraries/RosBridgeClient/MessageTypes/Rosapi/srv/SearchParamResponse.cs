/* 
 * This message is auto generated by ROS#. Please DO NOT modify.
 * Note:
 * - Comments from the original code will be written in their own line 
 * - Variable sized arrays will be initialized to array of size 0 
 * Please report any issues at 
 * <https://github.com/siemens/ros-sharp> 
 */

namespace RosSharp.RosBridgeClient.MessageTypes.Rosapi
{
    public class SearchParamResponse : Message
    {
        public const string RosMessageName = "rosapi/SearchParam";

        public string global_name { get; set; }

        public SearchParamResponse()
        {
            this.global_name = "";
        }

        public SearchParamResponse(string global_name)
        {
            this.global_name = global_name;
        }
    }
}
