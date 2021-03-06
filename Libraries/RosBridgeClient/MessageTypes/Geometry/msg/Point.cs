/* 
 * This message is auto generated by ROS#. Please DO NOT modify.
 * Note:
 * - Comments from the original code will be written in their own line 
 * - Variable sized arrays will be initialized to array of size 0 
 * Please report any issues at 
 * <https://github.com/siemens/ros-sharp> 
 */

using Newtonsoft.Json;

namespace RosSharp.RosBridgeClient.MessageTypes.Geometry
{
    public class Point : Message
    {
        [JsonIgnore]
        public const string RosMessageName = "geometry_msgs/Point";

        //  This contains the position of a point in free space
        public double x;
        public double y;
        public double z;

        public Point()
        {
            this.x = 0.0;
            this.y = 0.0;
            this.z = 0.0;
        }

        public Point(double x, double y, double z)
        {
            this.x = x;
            this.y = y;
            this.z = z;
        }
    }
}
