﻿/*
© Siemens AG, 2019
Author: Sifan Ye (sifan.ye@siemens.com)

Licensed under the Apache License, Version 2.0 (the "License");
you may not use this file except in compliance with the License.
You may obtain a copy of the License at
<http://www.apache.org/licenses/LICENSE-2.0>.
Unless required by applicable law or agreed to in writing, software
distributed under the License is distributed on an "AS IS" BASIS,
WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
See the License for the specific language governing permissions and
limitations under the License.
*/

namespace RosSharp.RosBridgeClient.Protocols
{
    public enum Protocol { WebSocketSharp, WebSocketNET , WebSocketUWP};

    public class ProtocolInitializer
    {
        public static IProtocol GetProtocol(Protocol protocol, string serverURL)
        {
            switch (protocol)
            {
                case Protocol.WebSocketSharp:
#if !WINDOWS_UWP
                    return new WebSocketSharpProtocol(serverURL);
#endif
                case Protocol.WebSocketNET:
#if !WINDOWS_UWP
                    return new WebSocketNetProtocol(serverURL);
#endif
                case Protocol.WebSocketUWP:
#if WINDOWS_UWP
                    return new WebSocketUWPProtocol(serverURL);
#else
                    return new WebSocketNetProtocol(serverURL);
#endif
                default:
                    return null;
            }
        }
    }
}
