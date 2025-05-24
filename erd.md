# 📊 Entity Relationship Diagram (ERD)

هذا المخطط يوضح العلاقات الأساسية بين الكيانات (Entities) المختلفة داخل نظام إدارة الجامعات الذي يتم تطويره في مشروعنا المفتوح المصدر.

---

## 🧱 الكيانات الرئيسية:

- **University**
- **Faculty**
- **Department**
- **Specialization**
- **Student**
- **Instructor**
- **Course**
- **Schedule**
- **Lecture**
- **Attendance**
- **Enrollment**
- **Grade**
- **Evaluation**

---

## 🔗 العلاقات بين الكيانات (Relationships):

| الكيان الرئيسي       | يرتبط بـ                  | نوع العلاقة       |
|----------------------|---------------------------|--------------------|
| University           | Faculties, Students       | One-to-Many        |
| Faculty              | Departments               | One-to-Many        |
| Department           | Specializations, Students | One-to-Many        |
| Specialization       | Students                  | One-to-Many        |
| Instructor           | Courses, Schedules        | Many-to-Many / 1:N |
| Course               | Students, Schedules       | Many-to-Many / 1:N |
| Schedule             | Course, Instructor        | Many-to-One        |
| Lecture              | Schedule, Course, Instructor | Many-to-One     |
| Attendance           | Lecture, Student          | Many-to-One        |
| Enrollment           | Course, Student           | Many-to-One        |
| Grade                | Enrollment                | One-to-Many        |
| Evaluation           | Instructor, Student       | Many-to-One        |

---

## 🖼️ ERD Diagram Image

> يمكنك الاطلاع على المخطط الكامل المرئي من خلال الصورة التالية:

![University ERD](./ERD/university-erd.png)

---

## 📥 ملاحظات

- الصورة موجودة في المسار: `docs/ERD/university-erd.png`
- يتم تحديث هذا الملف عند أي تغيير في الهيكل أو إضافة كيانات جديدة.

---

## 🔁 روابط مهمة

- [العودة إلى الصفحة الرئيسية للمشروع](../README.md)
- [شرح الطبقات (Architecture)](./architecture.md)

