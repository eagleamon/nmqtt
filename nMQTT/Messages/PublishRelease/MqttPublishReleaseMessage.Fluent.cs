/* 
 * nMQTT, a .Net MQTT v3 client implementation.
 * http://wiki.github.com/markallanson/nmqtt
 * 
 * Copyright (c) 2009 Mark Allanson (mark@markallanson.net)
 *
 * Licensed under the MIT License. You may not use this file except 
 * in compliance with the License. You may obtain a copy of the License at
 *
 *     http://www.opensource.org/licenses/mit-license.php
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace Nmqtt
{
    /// <summary>
    /// Implementation of an MQTT Publish Release Message.
    /// </summary>
    public sealed partial class MqttPublishReleaseMessage : MqttMessage
    {
        /// <summary>
        /// Sets the message identifier on the publishrelease message.
        /// </summary>
        /// <param name="messageIdentifier">The ID of the message.</param>
        /// <returns>The updated instance of the MqttPublishReleaseMessage.</returns>
        public MqttPublishReleaseMessage WithMessageIdentifier(short messageIdentifier)
        {
            this.VariableHeader.MessageIdentifier = messageIdentifier;
            return this;
        }
    }
}
