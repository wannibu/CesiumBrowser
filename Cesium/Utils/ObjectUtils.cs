using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Xml.Serialization;

namespace Cesium.Utils
{
    public static class ObjectUtils
    {
        //
        // 摘要:
        //     判断指定的对象是否是空引用，或空字符串。
        //
        // 参数:
        //   value:
        //     需要测试的对象
        //
        // 返回结果:
        //     如果 value 参数为空引用或空字符串 ("")，则为 true；否则为 false。
        public static bool IsNullOrEmpty(this object value)
        {
            if (value == null || value == DBNull.Value || value.ToString().Length == 0)
            {
                return true;
            }

            return false;
        }

        //
        // 摘要:
        //     判断指定的对象是否是空引用，或空字符串， 或空白字符。
        //
        // 参数:
        //   value:
        //     需要测试的对象
        //
        // 返回结果:
        //     如果 value 参数为空引用或空字符串 ("")或空白字符，则为 true；否则为 false。
        public static bool IsNullOrEmptyOrWhiteSpace(this object value)
        {
            if (value == null || value == DBNull.Value || value.ToString().Length == 0 || string.IsNullOrWhiteSpace(value.ToString()))
            {
                return true;
            }

            return false;
        }

        //
        // 摘要:
        //     为对象创建一个拷贝
        //
        // 参数:
        //   obj:
        //     需要创建拷贝的对象
        //
        // 返回结果:
        //     新建立的拷贝对象
        public static object CreateCopy(object obj)
        {
            return CreateCopy(obj, FormatterType.BinaryFormatter);
        }

        //
        // 摘要:
        //     为对象创建一个拷贝
        //
        // 参数:
        //   obj:
        //     需要创建拷贝的对象
        //
        //   formatterType:
        //     格式类型
        //
        // 返回结果:
        //     新建立的拷贝对象
        public static object CreateCopy(object obj, FormatterType formatterType)
        {
            //IL_0013: Unknown result type (might be due to invalid IL or missing references)
            //IL_0019: Expected O, but got Unknown
            if (obj == null)
            {
                return null;
            }

            object obj2 = null;
            MemoryStream memoryStream = new MemoryStream();
            IFormatter formatter = null;
            switch (formatterType)
            {
                case FormatterType.NetDataContract:
                    formatter = new NetDataContractSerializer();
                    break;

                default:
                    formatter = new BinaryFormatter();
                    break;
            }
            formatter.Serialize(memoryStream, obj);
            memoryStream.Position = 0L;
            obj2 = formatter.Deserialize(memoryStream);
            memoryStream.Close();
            memoryStream.Dispose();
            formatter = null;
            return obj2;
        }

        //
        // 摘要:
        //     将对象序列化为字节流
        //
        // 参数:
        //   obj:
        //     需要序列化的对象
        //
        // 返回结果:
        //     序列化后的字节流
        public static byte[] GetObjectSream(object obj)
        {
            if (obj == null)
            {
                return null;
            }

            byte[] array = null;
            MemoryStream memoryStream = new MemoryStream();
            IFormatter formatter = new BinaryFormatter();
            formatter.Serialize(memoryStream, obj);
            array = memoryStream.ToArray();
            memoryStream.Close();
            memoryStream.Dispose();
            return array;
        }

        //
        // 摘要:
        //     将字节流反序列化为对象
        //
        // 参数:
        //   bytes:
        //     需要反序列化的字节流
        //
        // 返回结果:
        //     反序列化后的对象
        public static object GetObject(byte[] bytes)
        {
            if (bytes == null)
            {
                return null;
            }

            object obj = null;
            MemoryStream memoryStream = new MemoryStream(bytes);
            IFormatter formatter = new BinaryFormatter();
            obj = formatter.Deserialize(memoryStream);
            memoryStream.Close();
            memoryStream.Dispose();
            return obj;
        }

        //
        // 摘要:
        //     判断返回主键值是否是一个无效的值。
        //
        // 参数:
        //   pkValue:
        //     主键值
        //
        // 返回结果:
        //     主键值是一个无效的值，则为 true；否则为 false。
        public static bool IsEmptyPrimaryKey(this object pkValue)
        {
            if (pkValue == null)
            {
                return true;
            }

            string text = pkValue as string;
            if (text != null)
            {
                return string.IsNullOrWhiteSpace(text);
            }

            if (pkValue is int)
            {
                return (int)pkValue == 0;
            }

            if (pkValue is long)
            {
                return (long)pkValue == 0;
            }

            if (pkValue.GetType().IsValueType)
            {
                object objA = Activator.CreateInstance(pkValue.GetType());
                return object.Equals(objA, pkValue);
            }

            return false;
        }

        //
        // 摘要:
        //     返回字符串
        //
        // 参数:
        //   obj:
        public static string Object2String(object obj)
        {
            if (obj != null)
            {
                return obj.ToString();
            }

            return "";
        }

        //
        // 摘要:
        //     得到对象对应的数值
        //
        // 参数:
        //   obj:
        //     要转换的对象
        //
        //   iDefaultValue:
        //     默认值
        //
        // 返回结果:
        //     得到的int值
        public static int Object2Int(object obj, int iDefaultValue = 0)
        {
            if (obj.IsNullOrEmptyOrWhiteSpace())
            {
                return iDefaultValue;
            }

            try
            {
                return Convert.ToInt32(obj);
            }
            catch
            {
                return iDefaultValue;
            }
        }

        //
        // 摘要:
        //     得到对象对应的数值
        //
        // 参数:
        //   obj:
        //     要转换的对象
        //
        //   iDefaultValue:
        //     默认值
        //
        // 返回结果:
        //     得到的bool值
        public static bool Object2Bool(object obj, bool iDefaultValue = false)
        {
            if (obj.IsNullOrEmptyOrWhiteSpace())
            {
                return iDefaultValue;
            }

            try
            {
                return Convert.ToBoolean(obj);
            }
            catch
            {
                return iDefaultValue;
            }
        }

        //
        // 摘要:
        //     得到对象对应的数值
        //
        // 参数:
        //   obj:
        //     要转换的对象
        //
        //   iDefaultValue:
        //     默认值
        //
        // 返回结果:
        //     得到的int值
        public static long Object2Int64(object obj, long iDefaultValue = 0L)
        {
            if (obj.IsNullOrEmptyOrWhiteSpace())
            {
                return iDefaultValue;
            }

            try
            {
                return Convert.ToInt64(obj);
            }
            catch
            {
                return iDefaultValue;
            }
        }

        //
        // 摘要:
        //     得到对象对应的数值
        //
        // 参数:
        //   obj:
        //     要转换的对象
        //
        //   iDefaultValue:
        //     默认值
        //
        // 返回结果:
        //     得到的int值
        public static decimal ToDecimal(object obj, decimal iDefaultValue = 0m)
        {
            if (obj.IsNullOrEmptyOrWhiteSpace())
            {
                return iDefaultValue;
            }

            try
            {
                return Convert.ToDecimal(obj);
            }
            catch
            {
                return iDefaultValue;
            }
        }

        //
        // 摘要:
        //     判断FormId是否是动态构造
        //
        // 参数:
        //   formId:
        public static bool IsDynamicFromId(string formId)
        {
            bool result = false;
            int num = formId.IndexOf("@");
            if (!string.IsNullOrWhiteSpace(formId) && num >= 0 && num < formId.Length)
            {
                result = true;
            }

            return result;
        }

        //
        // 摘要:
        //     获取对象的字符串，如果对象为空，返回string.Empty
        //
        // 参数:
        //   obj:
        //     对象
        //
        // 返回结果:
        //     对象的字符串
        public static string GetString(this object obj)
        {
            if (obj != null && obj != DBNull.Value)
            {
                return obj.ToString();
            }

            return string.Empty;
        }

        public static string Serializer(Type type, object obj)
        {
            string empty = string.Empty;
            MemoryStream memoryStream = new MemoryStream();
            XmlSerializer xmlSerializer = new XmlSerializer(type);
            xmlSerializer.Serialize(memoryStream, obj);
            memoryStream.Position = 0L;
            StreamReader streamReader = new StreamReader(memoryStream);
            return streamReader.ReadToEnd();
        }

        public static object Deserialize(Type type, string xml)
        {
            StringReader textReader = new StringReader(xml);
            XmlSerializer xmlSerializer = new XmlSerializer(type);
            return xmlSerializer.Deserialize(textReader);
        }

        //
        // 摘要:
        //     通过反射浅复制
        public static object CloneByReflection(object obj)
        {
            object obj2 = obj;
            if (obj != null)
            {
                Type type = obj.GetType();
                obj2 = type.Assembly.CreateInstance(type.FullName);
                PropertyInfo[] properties = type.GetProperties();
                PropertyInfo[] array = properties;
                foreach (PropertyInfo propertyInfo in array)
                {
                    if (propertyInfo.CanRead && propertyInfo.CanWrite)
                    {
                        object value = propertyInfo.GetValue(obj, null);
                        propertyInfo.SetValue(obj2, value, null);
                    }
                }
            }

            return obj2;
        }

        //
        // 摘要:
        //     对象深拷贝
        //
        // 参数:
        //   obj:
        //
        // 类型参数:
        //   T:
        public static T DeepClone<T>(T obj)
        {
            MemoryStream memoryStream = new MemoryStream();
            BinaryFormatter binaryFormatter = new BinaryFormatter();
            binaryFormatter.Serialize(memoryStream, obj);
            memoryStream.Position = 0L;
            return (T)binaryFormatter.Deserialize(memoryStream);
        }

        //
        // 摘要:
        //     得到分批次数
        //
        // 参数:
        //   allCount:
        //
        //   everyCount:
        public static int GetBatchTimes(int allCount, int everyCount)
        {
            return allCount / everyCount + ((allCount % everyCount != 0) ? 1 : 0);
        }

        //
        // 摘要:
        //     字典增加值
        //
        // 参数:
        //   dic:
        //
        //   key:
        //
        //   value:
        //
        // 类型参数:
        //   T1:
        //
        //   T2:
        public static void AddT2<T1, T2>(this Dictionary<T1, List<T2>> dic, T1 key, T2 value)
        {
            List<T2> list = (dic.ContainsKey(key) ? dic[key] : new List<T2>());
            if (!list.Contains(value))
            {
                list.Add(value);
            }

            dic[key] = list;
        }
    }

    public enum FormatterType
    {
        BinaryFormatter,
        NetDataContract
    }

}
