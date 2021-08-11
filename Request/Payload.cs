using System;
using System.Collections.Generic;
using System.Text;

namespace Request
{
    /// <summary>
    /// Payload 的類別, 會轉成json 格式放到request
    /// </summary>
    public class Payload
    {
        /// <summary>
        /// dtno 欄位
        /// </summary>
        public int dtno { get; set; }

        /// <summary>
        /// ftno 欄位
        /// </summary>
        public int ftno { get; set; }

        /// <summary>
        /// params 欄位
        /// </summary>
        public string @params { get; set; }

        /// <summary>
        /// keymap 欄位
        /// </summary>
        public string keyMap { get; set; }

        /// <summary>
        /// assignSpid 欄位
        /// </summary>
        public string assignSpid { get; set; }
    }
}
