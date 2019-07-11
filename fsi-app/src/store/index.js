import Vue from 'vue'
import Vuex from 'vuex'
import VuexPersistence from 'vuex-persist'
import { AuthModule } from '@/store/modules/auth.js'

Vue.use(Vuex)

const vuexPersist = new VuexPersistence({
	strictMode: true,
	storage: window.localStorage
})

export default new Vuex.Store({
	modules: {
		auth: AuthModule
	},
	mutations: {
		RESTORE_MUTATION: vuexPersist.RESTORE_MUTATION
	},
	actions: {

	},
	plugins: [vuexPersist.plugin],
	strict: true
})
