import express from 'express';

const app = express();
const PORT = 5000;

app.use(
	express.urlencoded({
		extended: true,
	})
);
app.use(express.json());

// A browser can ONLY make get request
app.get('/', (request, response) => {
	console.log('WORKING / GET');
	response.send('Hello World!');
});

app.listen(PORT, () => {
	console.log(`ServerRUNNING on http://localhost:${PORT}`);
});
