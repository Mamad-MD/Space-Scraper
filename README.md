# 🚀 Space Scraper

یک بازی VR کوچک در یونیتی: داخل یک ایستگاه فضایی سبک Sci-Fi می‌ایستی، با یک تفنگ لیزری تکه‌های زباله و سنگ‌های فضایی شناور رو می‌شکنی و بعد باید تکه‌های شکسته‌شده رو جمع کنی و داخل سطل زباله بندازی.

<p align="center">
  <img src="docs/media/banner.gif" alt="Space Scraper gameplay" width="720">
</p>

> عکس‌ها و گیف‌های بالا و پایین این صفحه placeholder هستن. کافیه گیم‌پلی رو ضبط کنی، فایل‌ها رو داخل پوشه‌ی `docs/media/` بذاری و اسم فایل‌ها با اسمی که اینجا لینک شده مطابقت داشته باشه تا خودکار نمایش داده بشن.

---

## 🎮 بازی چیه

بازیکن داخل یک محیط فضایی ساخته‌شده با [Sci-Fi Styled Modular Pack](https://assetstore.unity.com) قرار می‌گیره و دو کار انجام می‌ده:

- **شلیک با تفنگ متئور** — تفنگ رو با دست VR می‌گیری، ماشه رو می‌کشی، یک ری‌کست از لوله‌ی تفنگ به بیرون زده می‌شه و هر چیزی که در برچسب `Breakable` باشه رو بعد از چند ثانیه نگه‌داشتن لیزر روی هدف، تیکه‌تیکه می‌کنه.
- **جمع‌آوری زباله** — تیکه‌های شکسته‌شده رو با دست می‌گیری و داخل سطل زباله می‌ندازی. سطل یک ناحیه‌ی تریگر داره که هر شیء با تگ درست رو که وارد بشه، غیرفعال می‌کنه.

هدف اصلی، تمیز کردن فضای اطراف ایستگاهه.

<p align="center">
  <img src="docs/media/screenshot-01.jpg" alt="محیط بازی" width="45%">
  <img src="docs/media/screenshot-02.jpg" alt="شلیک با تفنگ متئور" width="45%">
</p>

## 🛠 تکنولوژی‌ها

| بخش | نسخه |
|---|---|
| Unity | 2022.3.62f3 (LTS) |
| XR Interaction Toolkit | 2.6.4 |
| OpenXR Plugin | 1.14.3 |
| XR Management | 4.7.0 |

## 🧩 اسکریپت‌های اصلی

پروژه چند اسکریپت سفارشی داره که منطق اصلی بازی رو می‌سازن:

- `MeteorPistol.cs` — گوش می‌ده به رویدادهای گرفتن و فعال‌سازی XR (کشیدن ماشه)، پارتیکل شلیک رو پخش می‌کنه و با `Physics.Raycast` هدف روی لایه‌ی مشخص‌شده رو پیدا می‌کنه.
- `Breakable.cs` — روی هر شیء قابل شکستن قرار می‌گیره؛ وقتی تایمر شکستن پر بشه، قطعات از پیش تعریف‌شده رو فعال می‌کنه، از parent جدا می‌کنه و شیء اصلی رو غیرفعال می‌کنه.
- `TriggerZone.cs` — یک ناحیه‌ی تریگر عمومی که با تگ مشخص کار می‌کنه و یک `UnityEvent` با شیء وارد‌شده صدا می‌زنه.
- `TrashCan.cs` — به رویداد `TriggerZone` گوش می‌ده و هر شیء که وارد سطل بشه رو غیرفعال می‌کنه.
- `DisableGrabbingHandModel.cs` — مدل دست VR رو موقع گرفتن یک شیء مخفی می‌کنه تا مدل خود اسلحه یا شیء دیده بشه، نه دست شفاف روی اون.

## ▶️ اجرا کردن پروژه

1. Unity Hub رو باز کن و نسخه‌ی `2022.3.62f3` رو نصب کن (اگه نداری).
2. ریپو رو کلون کن:
   ```bash
   git clone https://github.com/Mamad-MD/Space-Scraper.git
   ```
3. پروژه رو با همون نسخه‌ی یونیتی از داخل Unity Hub باز کن و بذار پکیج‌ها sync بشن.
4. صحنه‌ی `Assets/Scenes/SampleScene.unity` رو باز کن.
5. یک هدست XR (سازگار با OpenXR) وصل کن و Play بزن.

بدون هدست هم می‌شه صحنه رو با XR Device Simulator (که همراه XR Interaction Toolkit میاد) تست کرد.

## 📁 ساختار پروژه

```
Assets/
├── Scenes/SampleScene.unity        صحنه‌ی اصلی بازی
├── MeteorPistol.cs                 منطق شلیک و شکستن اشیا
├── Breakable.cs                    رفتار اشیای قابل شکستن
├── TriggerZone.cs / TrashCan.cs    منطق سطل زباله
├── DisableGrabbingHandModel.cs     مدیریت نمایش دست VR
├── Sci-Fi Styled Modular Pack/     مدل‌ها و متریال‌های محیط ایستگاه فضایی
├── Lets Make a VR Game/            دست‌های XR، تفنگ، سنگ‌های فضایی
└── AkdumanDev/                     ست ابزار کار (دکور)
```

## 🎬 دمو

<p align="center">
  <video src="docs/media/demo.mp4" controls width="720">
    مرورگرت از تگ ویدیو پشتیبانی نمی‌کنه — می‌تونی مستقیم فایل رو از <code>docs/media/demo.mp4</code> باز کنی.
  </video>
</p>

اگه ویدیو داخل GitHub خودت رو باز نکرد (بعضی مرورگرها تگ `<video>` رو در README رندر نمی‌کنن)، فایل رو مستقیم آپلود کن داخل یک Issue یا Release و لینکش رو اینجا جایگزین کن — GitHub خودش پلیر می‌سازه.

## 🙏 اعتبارات

بخشی از asset های محیط و مدل‌ها از منابع زیر استفاده شده:

- Sci-Fi Pistol model — Pablo88 ([Sketchfab](https://sketchfab.com/3d-models/sci-fi-pistol-3d7aca39ec9f4aba98642705c0bed2bb))
- Robot Hand — Inferno Digital / DudleyLong ([RoboHands-UnityXR](https://github.com/InfernoDigital/RoboHands-UnityXR))
- Milky Way panorama — ESO/S. Brunier
- UI 3D Examples — Unity Technologies، XR Interaction Toolkit Examples

## 👤 توسعه‌دهنده

ساخته‌شده توسط [Mamad-MD](https://github.com/Mamad-MD)
