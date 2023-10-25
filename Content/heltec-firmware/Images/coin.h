// DogeCoin image (.xbm format)
// Basically a circle with the letter 'D' in the center
#define coin_width 64
#define coin_height 64
static unsigned char coin_bits[] = {
   0x00, 0x00, 0x00, 0xf8, 0x1f, 0x00, 0x00, 0x00, 0x00, 0x00, 0xc0, 0xff,
   0xff, 0x03, 0x00, 0x00, 0x00, 0x00, 0xf0, 0xff, 0xff, 0x0f, 0x00, 0x00,
   0x00, 0x00, 0xfe, 0xff, 0xff, 0x7f, 0x00, 0x00, 0x00, 0x00, 0xff, 0xff,
   0xff, 0xff, 0x00, 0x00, 0x00, 0xc0, 0xff, 0xff, 0xff, 0xff, 0x03, 0x00,
   0x00, 0xe0, 0xff, 0xff, 0xff, 0xff, 0x07, 0x00, 0x00, 0xf8, 0xff, 0xff,
   0xff, 0xff, 0x1f, 0x00, 0x00, 0xfc, 0xff, 0xff, 0xff, 0xff, 0x3f, 0x00,
   0x00, 0xfe, 0xff, 0xff, 0xff, 0xff, 0x7f, 0x00, 0x00, 0xff, 0xff, 0xff,
   0xff, 0xff, 0xff, 0x00, 0x80, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0x01,
   0x80, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0x01, 0xc0, 0xff, 0xff, 0xff,
   0xff, 0xff, 0xff, 0x03, 0xe0, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0x07,
   0xe0, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0x07, 0xf0, 0xff, 0x1f, 0x00,
   0xc0, 0xff, 0xff, 0x0f, 0xf8, 0xff, 0x1f, 0x00, 0x00, 0xfe, 0xff, 0x0f,
   0xf8, 0xff, 0x1f, 0x00, 0x00, 0xfc, 0xff, 0x1f, 0xf8, 0xff, 0x1f, 0x00,
   0x00, 0xf0, 0xff, 0x1f, 0xfc, 0xff, 0x1f, 0x00, 0x00, 0xe0, 0xff, 0x3f,
   0xfc, 0xff, 0x1f, 0xfc, 0x1f, 0xe0, 0xff, 0x3f, 0xfe, 0xff, 0x1f, 0xfc,
   0x7f, 0xc0, 0xff, 0x7f, 0xfe, 0xff, 0x1f, 0xfc, 0xff, 0xc0, 0xff, 0x7f,
   0xfe, 0xff, 0x1f, 0xfc, 0xff, 0x81, 0xff, 0x7f, 0xfe, 0xff, 0x1f, 0xfc,
   0xff, 0x81, 0xff, 0x7f, 0xff, 0xff, 0x1f, 0xfc, 0xff, 0x83, 0xff, 0x7f,
   0xff, 0xff, 0x1f, 0xfc, 0xff, 0x03, 0xff, 0xff, 0xff, 0xff, 0x1f, 0xfc,
   0xff, 0x03, 0xff, 0xff, 0xff, 0xff, 0x03, 0x00, 0xf8, 0x03, 0xff, 0xff,
   0xff, 0xff, 0x03, 0x00, 0xf8, 0x03, 0xff, 0xff, 0xff, 0xff, 0x03, 0x00,
   0xf8, 0x03, 0xff, 0xff, 0xff, 0xff, 0x03, 0x00, 0xf8, 0x03, 0xff, 0xff,
   0xff, 0xff, 0x03, 0x00, 0xf8, 0x03, 0xff, 0xff, 0xff, 0xff, 0x1f, 0xfc,
   0xff, 0x03, 0xff, 0xff, 0xff, 0xff, 0x1f, 0xfc, 0xff, 0x03, 0xff, 0xff,
   0xff, 0xff, 0x1f, 0xfc, 0xff, 0x03, 0xff, 0xff, 0xfe, 0xff, 0x1f, 0xfc,
   0xff, 0x83, 0xff, 0x7f, 0xfe, 0xff, 0x1f, 0xfc, 0xff, 0x81, 0xff, 0x7f,
   0xfe, 0xff, 0x1f, 0xfc, 0xff, 0x81, 0xff, 0x7f, 0xfe, 0xff, 0x1f, 0xfc,
   0xff, 0xc0, 0xff, 0x7f, 0xfe, 0xff, 0x1f, 0xfc, 0x7f, 0xc0, 0xff, 0x7f,
   0xfc, 0xff, 0x1f, 0xfc, 0x1f, 0xe0, 0xff, 0x3f, 0xfc, 0xff, 0x1f, 0x00,
   0x00, 0xe0, 0xff, 0x3f, 0xf8, 0xff, 0x1f, 0x00, 0x00, 0xf0, 0xff, 0x1f,
   0xf8, 0xff, 0x1f, 0x00, 0x00, 0xfc, 0xff, 0x1f, 0xf8, 0xff, 0x1f, 0x00,
   0x00, 0xfe, 0xff, 0x0f, 0xf0, 0xff, 0x1f, 0x00, 0xc0, 0xff, 0xff, 0x0f,
   0xe0, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0x07, 0xe0, 0xff, 0xff, 0xff,
   0xff, 0xff, 0xff, 0x07, 0xc0, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0x03,
   0x80, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0x01, 0x80, 0xff, 0xff, 0xff,
   0xff, 0xff, 0xff, 0x01, 0x00, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0x00,
   0x00, 0xfe, 0xff, 0xff, 0xff, 0xff, 0x7f, 0x00, 0x00, 0xfc, 0xff, 0xff,
   0xff, 0xff, 0x3f, 0x00, 0x00, 0xf8, 0xff, 0xff, 0xff, 0xff, 0x1f, 0x00,
   0x00, 0xe0, 0xff, 0xff, 0xff, 0xff, 0x07, 0x00, 0x00, 0xc0, 0xff, 0xff,
   0xff, 0xff, 0x03, 0x00, 0x00, 0x00, 0xff, 0xff, 0xff, 0xff, 0x00, 0x00,
   0x00, 0x00, 0xfc, 0xff, 0xff, 0x3f, 0x00, 0x00, 0x00, 0x00, 0xf0, 0xff,
   0xff, 0x0f, 0x00, 0x00, 0x00, 0x00, 0xc0, 0xff, 0xff, 0x03, 0x00, 0x00,
   0x00, 0x00, 0x00, 0xf8, 0x1f, 0x00, 0x00, 0x00 };