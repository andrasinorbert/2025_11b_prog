const express = require('express');
const mysql= require('mysql2');

const app = express();

const port = 3000;

app.use(express.json());

const db=mysql.createConnection({
    host: 'localhost',
    user: 'root',
    password: '',
    database: '2025_11b'
});

db.connect( (err)=>{
    if(err){
        console.error("MySQL kapcsolódási hiba:",err);
        return;
    }
    console.log('Sikeres MySQL kapcsolódás!');
});

app.get('/', (req, res) => {
    res.send('Hello World');
});

app.get('/users', (req, res) => {
    let sql="Select * FROM users;";

    db.query(sql, (err,result)=>{
        if(err) return res.status(500).json({error: err.message });

        res.json(result);
    });
});

// Egy felhasználó lekérése név alapján
app.get('/users/:name', (req, res) => {
    const name = req.params.name;

    db.query(
        'SELECT * FROM users WHERE name = ?', [name],
        (err, results) => {
            if (err) {
                return res.status(500).json({ error: err.message });
            }

            if (results.length === 0) {
                return res.status(404).json({ error: 'Nincs ilyen felhasználó' });
            }

            res.json(results[0]);
        }
    );
});

app.listen(port, () => {
    console.log(`Server running at http://localhost:${port}`);
});