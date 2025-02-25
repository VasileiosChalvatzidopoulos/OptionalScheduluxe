Περιγραφή ιδέας ομαδικής εργασίας:

Στα πλαίσια του μαθήματος “Ανάπτυξη και Αρχιτεκτονικές Πληροφοριακών Συστημάτων”, η ομάδα μας εκπόνησε μια εργασία για τη δημιουργία μιας καινοτόμου web εφαρμογής που στοχεύει στην προσωπική εμπειρία των ταξιδιωτών.  
Η εφαρμογή μας, διαθέσιμη στη διεύθυνση Welcome to Scheduluxe (http://ism.dmst.aueb.gr/ismgroup38/Scheduluxe/Home.jsp) παρέχει στους χρήστες τη δυνατότητα να δημιουργήσουν το δικό τους προσωποποιημένο ταξιδιωτικό πρόγραμμα. Οι χρήστες ξεκινούν επιλέγοντας τον προορισμό που επιθυμούν να επισκεφτούν, τον αριθμό των ημερών που σκοπεύουν να παραμείνουν, τον τύπο ταξιδιού (όπως περιπέτεια, χαλάρωση, εκπαίδευση ή φύση) και το εύρος κόστους.  
Μετά την εισαγωγή αυτών των στοιχείων, η εφαρμογή τους εμφανίζει το ταξιδιωτικό πρόγραμμα με αναλυτική παρουσίαση ανά ημέρα, καθώς και μια συνολική εικόνα για όλες τις ημέρες. Επιπλέον, διαθέτει έναν διαδραστικό χάρτη με τα σημεία ενδιαφέροντος, επιτρέποντας στους χρήστες να εξερευνούν καλύτερα τις διαθέσιμες δραστηριότητες και τα αξιοθέατα. Στην ιστοσελίδα που εμφανίζεται το πλήρες πρόγραμμα, οι χρήστες έχουν τη δυνατότητα να κατεβάσουν το πρόγραμμα σε μορφή αρχείου pdf, καθώς και να σχολιάσουν και να αξιολογήσουν τις δραστηριότητες του προγράμματος.

Περιγραφή use case (Edit your Profile):

Ο χρήστης μπορεί να επεξεργαστεί το προφίλ του ορίζοντας επιπρόσθετες πληροφορίες για αυτόν ή αλλάζοντας τις ήδη υπάρχουσες που είχε θέσει κατά την εγγραφή του.

Setup και εκτέλεση:

Για να εκτελέσει κάποιος το use case της εφαρμογής πρέπει να κατεβάσει από το github το αποθετήριο και να το ανοίξει μέσω visual studio (δηλαδή πατώντας Code και Open in Visual Studio). Έπειτα, πρέπει να κατεβάσει το πακέτο: MySql.EntityFrameworkCore 9.0.0.
Στη συνέχεια, πατώντας το κατάλληλο κουμπί για να τρέξει η εφαρμογή (local host), ο χρήστης βλέπει ένα μενού. Για να μπορέσει να επεξεργαστεί το προφίλ του θα πρέπει είτε να κάνει log in (πχ ένας λογαριασμός username = VasChal, password = 12345678) είτε Sign Up (και μετά login) αν δεν έχει λογαριασμό, συμπληρώνοντας όλα τα πεδία. Όταν έχει κάνει login, ο χρήστης μπορεί να πατήσει το κουμπί EditProfile και να αλλάξει την προσυμπληρωμένη φόρμα με τα στοιχεία του προφίλ του. ΠΡΟΣΟΧΗ! Λόγω κάποιων δυσκολιών που αντιμετώπησα στη δημιουργία της εργασίας και της έλλειψης χρόνου, ο χρήστης πρέπει οπωσδήποτε να συμπληρώσει το πεδίο Password είτε με τον παλιό του κωδικό είτε με ένα καινούριο (ουσιαστικά αλλάζοντάς τον).
Τέλος απλά πρέπει να πατήσει Save Changes.

Βάση Δεδομένων:

Ως Βάση Δεδομένων χρησιμοποιήθηκε η ΒΔ της ομαδικής εργασίας σε MySQL. Το connection string βρίσκεται ενσωματωμένο μέσα στον κώδικα και για αυτό το λόγο θα παραμείνει ιδιωτικό το αποθετήριο.

Διαφορές με ομαδική εργασία:

Είναι φανερό ότι μία διαφορά με την ομαδική εργασία είναι η html.
Επίσης, στην ομαδική εργασία όταν ένας χρήστης έκανε Sign up, δεν του ζητούσε όλα τα πεδία που ζητούνται στην προαιρετική εργασία (στην ομαδική μπορούσε να συμπληρώσει τα άλλα πεδία κατά τη διαδικασία EditProfile), ενώ τώρα πρέπει να τα συμπληρώσει όλα κατά το Sign Up.

Βοήθεια από πηγές και ΠΤΝ:

Καθώς οι γνώσεις μου σε ASP NET MVC ήταν μηδενικές πριν την έναρξη συγγραφής της συγκεκριμένης εργασίας, χρησιμοποίησα με εποικοδομητικό και εμπνευστικό τρόπο ορισμένες πηγές του διαδικτύου, όπως: 
1) https://learn.microsoft.com/en-us/aspnet/core/tutorials/first-mvc-app/start-mvc?view=aspnetcore-9.0&tabs=visual-studio
2) https://www.youtube.com/watch?v=hthzKj05w3w

Όσον αφορά τη χρήση ΠΤΝ, χρησιμοποίησα τη δωρεάν έκδοση του ChatGPT (ChatGPT-3.5): 

(Ενδέχεται να μην είναι με τη σωστή σειρά οι προτροπές)

Προτροπή 1:
Ερώτηση:
Ξεκίνησα αυτό το project σε ASP.NET Core MVC και προσπαθώ να συνδέσω τη ΒΔ, πρέπει να κάνω κάτι συγκεκριμένο για να δουλέψει με MySQL;
Απάντηση:
Ναι, για να συνδέσεις το ASP.NET Core MVC project με MySQL, πρέπει να κάνεις τα εξής:
1.	Εγκατάστησε το πακέτο NuGet Pomelo.EntityFrameworkCore.MySql.
2.	Πρόσθεσε το connection string στο appsettings.json με τη μορφή:
"ConnectionStrings": {
    "Default": "Server=localhost;Database=YourDatabaseName;User=YourUsername;Password=YourPassword;"
}
3.	Στο Program.cs, χρησιμοποίησε το connection string όπως αυτό:
builder.Services.AddDbContext<AppDbContext>(options =>
    options.UseMySQL(
        builder.Configuration.GetConnectionString("Default")
    ));
Έτσι θα μπορείς να χρησιμοποιήσεις τη MySQL στη βάση δεδομένων σου.
________________________________________
Προτροπή 2:
Ερώτηση:
Πρέπει να κάνω κάτι διαφορετκό για να λετουργήσουν τα sessions στο ASP.NET Core MVC; Θέλω να αποθηκεύω το UserId μετά το login.
Απάντηση:
Ναι, για να δουλέψουν τα Sessions στο ASP.NET Core MVC, πρέπει να:
1.	Προσθέσεις τη ρύθμιση για τα Sessions στο Program.cs:
builder.Services.AddSession(options =>
{
    options.IdleTimeout = TimeSpan.FromMinutes(30);
    options.Cookie.HttpOnly = true;
    options.Cookie.IsEssential = true;
});
app.UseSession();
2.	Σιγουρέψου ότι χρησιμοποιείς το HttpContext.Session στο Controller σου:
HttpContext.Session.SetString("UserId", user.Id.ToString());
Έτσι τα Sessions θα λειτουργούν κανονικά.
________________________________________
Προτροπή 3:
Ερώτηση:
Στο accountController χρησιμοποιώ RedirectToAction() μετά το Login όμως ο χρήστης δεν ανακατευθύνεται, γιατί;
Απάντηση:
Αυτό συνήθως συμβαίνει αν δεν υπάρχει το σωστό Action στον Controller που θες να ανακατευθυνθείς ή αν το Routing δεν είναι σωστό. Βεβαιώσου ότι:
1.	Το HomeController έχει Index() action:
public IActionResult Index()
{
    return View();
}
2.	Το Routing στο Program.cs έχει ρυθμιστεί σωστά:
app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");
Αυτό θα πρέπει να λύσει το πρόβλημα.
________________________________________
Προτροπή 4:
Ερώτηση:
Θέλω να προσθέσω έναν έλεγχο για το αν υπάρχει ήδη το Username κατά την εγγραφή. γίνεται αυτό μέσα στο controller;
Απάντηση:
Ναι, μπορείς να το κάνεις μέσα στο Register() action στο AccountController χρησιμοποιώντας κάτι σαν αυτό:
if (_context.Users.Any(u => u.UserName == model.Username))
{
    ModelState.AddModelError("Username", "Username already exists. Choose another one.");
}
Αυτό θα ελέγχει αν το Username υπάρχει ήδη και θα εμφανίζει μήνυμα λάθους.
________________________________________
Προτροπή 5:
Ερώτηση:
Στο EditProfile θέλω να εμφανίζεται το Username, αλλά να μην μπορεί να το αλλάξει ο χρήστης. Μπορώ να το κάνω read-only;
Απάντηση:
Ναι, στο View (EditProfile.cshtml), μπορείς να το κάνεις read-only έτσι:
<input asp-for="Username" class="form-control" readonly />
Έτσι θα εμφανίζεται το Username, αλλά ο χρήστης δεν θα μπορεί να το αλλάξει.
________________________________________
Προτροπή 6:
Ερώτηση:
Πρέπει να προσθέσω κάτι για να δουλέψει το ModelState.IsValid; δεν περνάει η φόρμα.
Απάντηση:
Ναι, το ModelState.IsValid εξαρτάται από τα Data Annotations στο ViewModel. Σιγουρέψου ότι έχεις χρησιμοποιήσει [Required] ή άλλες επικυρώσεις στο EditProfileViewModel όπως:
[Required]
public string FirstName { get; set; }
Επίσης, σιγουρέψου ότι τα input fields στο View έχουν asp-for που αντιστοιχεί στα properties του ViewModel.
________________________________________
Προτροπή 7:
Ερώτηση:
Χρειάζεται να κάνω κάτι συγκεκριμένο για να δουλέψει το Validation στα Forms; δεν δείχνει μηνύματα λάθους.
Απάντηση:
Βεβαιώσου ότι έχεις προσθέσει το ValidationScriptsPartial στο View σου:
@section Scripts {
    @await Html.RenderPartialAsync("_ValidationScriptsPartial")
}
Αυτό θα φορτώσει τα JavaScript scripts για το client-side validation.
________________________________________
Προτροπή 8:
Ερώτηση:
Πώς μπορώ να φορτώσω έναν χρήστη από τη βάση δεδομένων με βάση το userId;
Απάντηση:
Μπορείς να το κάνεις έτσι:
var user = await _context.Users.FirstOrDefaultAsync(u => u.Id == int.Parse(userId));
Αυτό ψάχνει στη βάση δεδομένων για τον πρώτο χρήστη με το συγκεκριμένο Id. Αν δεν βρει κανέναν, επιστρέφει null.




 

 

