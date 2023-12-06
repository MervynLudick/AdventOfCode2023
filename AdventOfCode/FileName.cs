//public static string convertLine(string input)
//{
//    string toReturn = "";
//    int length;

//    for (int i = 0; i < input.Length; i++)
//    {
//        switch (input[i])
//        {
//            case 'o':
//                length = 3;
//                if (input.Substring(i).Length >= length && input.Substring(i, length).Equals("one"))
//                {
//                    toReturn += "1";
//                    i += length - 2;
//                }
//                break;
//            case 't':
//                if ((i + 1) < input.Length)
//                    switch (input[i + 1])
//                    {
//                        case 'w':
//                            length = 3;
//                            if (input.Substring(i).Length >= length && input.Substring(i, length).Equals("two"))
//                            {
//                                toReturn += "2";
//                                i += length - 2;
//                            }
//                            break;
//                        case 'h':
//                            length = 5;
//                            if (input.Substring(i).Length >= length && input.Substring(i, length).Equals("three"))
//                            {
//                                toReturn += "3";
//                                i += length - 2;
//                            }
//                            break;
//                    }
//                break;
//            case 'f':
//                if ((i + 1) < input.Length)
//                    switch (input[i + 1])
//                    {
//                        case 'o':
//                            length = 4;
//                            if (input.Substring(i).Length >= length && input.Substring(i, length).Equals("four"))
//                            {
//                                toReturn += "4";
//                                i += length - 2;
//                            }
//                            break;
//                        case 'i':
//                            length = 4;
//                            if (input.Substring(i).Length >= length && input.Substring(i, length).Equals("five"))
//                            {
//                                toReturn += "5";
//                                i += length - 2;
//                            }
//                            break;
//                    }
//                break;
//            case 's':
//                if ((i + 1) < input.Length)
//                    switch (input[i + 1])
//                    {
//                        case 'i':
//                            length = 3;
//                            if (input.Substring(i).Length >= length && input.Substring(i, length).Equals("six"))
//                            {
//                                toReturn += "6";
//                                i += length - 2;
//                            }
//                            break;
//                        case 'e':
//                            length = 5;
//                            if (input.Substring(i).Length >= length && input.Substring(i, length).Equals("seven"))
//                            {
//                                toReturn += "7";
//                                i += length - 2;
//                            }
//                            break;
//                    }
//                break;
//            case 'e':
//                length = 5;
//                if (input.Substring(i).Length >= length && input.Substring(i, length).Equals("eight"))
//                {
//                    toReturn += "8";
//                    i += length - 2;
//                }
//                break;
//            case 'n':
//                length = 4;
//                if (input.Substring(i).Length >= length && input.Substring(i, length).Equals("nine"))
//                {
//                    toReturn += "9";
//                    i += length - 2;
//                }
//                break;
//            default:
//                toReturn += input[i];
//                break;
//        }
//    }

//    return toReturn;
//}