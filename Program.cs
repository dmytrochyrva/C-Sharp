// Implicit Conversion
byte b = 1;
int i = b;
float c = i;

// Explicit Conversion
int ii = 24;
byte bb = (byte)ii;
float cc = 1.0f;
int fi = (int)cc;

// Non-Compatible Conversion
string s = "123";
int si = int.Parse(s);
int li = Convert.ToInt32(s);

// Convert Class Numbers
Convert.ToByte(cc);
Convert.ToInt16(s);
Convert.ToInt32(s);
Convert.ToInt64(s);
Convert.ToDouble(ii);
Convert.ToDecimal(ii);

// Convert Class Text
Convert.ToChar(ii);
Convert.ToString(i);
