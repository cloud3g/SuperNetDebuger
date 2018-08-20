using System;
using System.Collections.Generic;
using System.Text;
using LeafSoft.Lib;
/*---------------作者：Maximus Ye----------------------*/
/*---------------时间：2013年8月16日---------------*/
/*---------------邮箱：yq@yyzq.net---------*/
/*---------------QQ：275623749---------*/
/*本软件也耗费了我不少的时间和精力，希望各位同行们尊重个人劳动成果，
 * 如果在此版本的基础上修改发布新的版本，请包含原作者信息（包括代码和UI界面相关信息)，为中国的
 * 开源事业做出一点贡献。*/
namespace LeafSoft.Model
{
    /// <summary>
    /// 命令实体模型
    /// </summary>
    public class CMD
    {
        EnumType.DataEncode _DataEncode = EnumType.DataEncode.Hex;
        string _strCMD = "";
        byte[] _byteCMD = null;

        public CMD(EnumType.DataEncode DataEncode, byte[] data)
        {
            _DataEncode = DataEncode;
            _byteCMD = data;
            switch (_DataEncode)
            {
                case EnumType.DataEncode.Hex:
                    foreach (byte b in _byteCMD)
                    {
                        _strCMD += string.Format("{0:X2} ", b);
                    }
                    _strCMD = _strCMD.TrimEnd();
                    break;
                case EnumType.DataEncode.ASCII:
                    _strCMD = new ASCIIEncoding().GetString(_byteCMD);
                    break;
                case EnumType.DataEncode.UTF8:
                    _strCMD = new UTF8Encoding().GetString(_byteCMD);
                    break;
                case EnumType.DataEncode.GB2312:
                    _strCMD = Encoding.GetEncoding("GB2312").GetString(_byteCMD);
                    break;
            }
        }

        /// <summary>
        /// 命令类型
        /// </summary>
        public EnumType.DataEncode ContentType
        {
            get
            {
                return _DataEncode;
            }
        }

        /// <summary>
        /// 命令类型
        /// </summary>
        public string ContentTypeName
        {
            get
            {
                return _DataEncode.ToString();
            }
        }

        /// <summary>
        /// 命令字符串
        /// </summary>
        public string Text
        {
            get {
                return _strCMD;
            }
        }

        /// <summary>
        /// 命令字节数组
        /// </summary>
        public byte[] Bytes
        {
            get
            {
                return _byteCMD;
            }
        }
    }
}
